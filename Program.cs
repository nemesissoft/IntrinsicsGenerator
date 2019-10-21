using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SF = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace IntrinsicsGenerator
{
    class Program
    {
        private static readonly Regex _instructionNamePattern = new Regex(@"
(?<Instruction>
  \b_
  [^_]
  [_A-Za-z0-9]*
  \b
)
",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.CultureInvariant |
            RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled
        );
        
        static void Main(string[] args)
        {
            if (args?.Length != 2 || !(args[0] is { } dir) || !Directory.Exists(dir) || !(args[1] is { } outFile))
            {
                Console.WriteLine("2 parameters are needed - existing folder path and output file");
                return;
            }


            var methods = ProcessFolder(dir);
            SaveCode(methods, outFile);
        }

        private static void SaveCode(IList<(string Namespace, string Class, string Instruction, MethodDeclarationSyntax Method)> methods, string outFile)
        {
            using var fileStream = new FileStream(outFile, FileMode.Create, FileAccess.Write);
            using var writer = new StreamWriter(fileStream);

            writer.WriteLine(@"//GENERATED == DO NOT EDIT
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

// ReSharper disable once CheckNamespace
namespace Fast
{
    public static class Intrinsics
    {");

            foreach (var (ns, @class, instruction, method) in methods)
            {
                var oldName = method.Identifier.Text;

                string newIdentifier = GetIdentifier(@class, instruction, method);
                var newMethod = method.WithIdentifier(
                        SF.Identifier(newIdentifier)
                            .WithTrailingTrivia(SF.Comment($"/*{@class}.{oldName}*/"))
                        )
                    ;

                var skipNewModifier = newMethod.Modifiers.Where(m => !m.IsKind(SyntaxKind.NewKeyword));

                newMethod = newMethod.WithModifiers(SF.TokenList(skipNewModifier));

                var hadBody = newMethod.Body != null;
                newMethod = newMethod.WithBody(null).WithExpressionBody(null);

                var callingNamespace = ns.Split('.').Aggregate<string, NameSyntax>(null,
                    (current, str) => current == null
                            ? (NameSyntax)SF.IdentifierName(str)
                            : SF.QualifiedName(current, SF.IdentifierName(str))
                );


                ExpressionSyntax call =
                    SF.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                        SF.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                            callingNamespace,
                            SF.IdentifierName(@class)
                        ),
                        SF.IdentifierName(oldName)
                    );

                var parameters = newMethod.ParameterList.Parameters.Select(p => p.Identifier.Text);


                var callingArgs = new SeparatedSyntaxList<ArgumentSyntax>().AddRange
                (new[]
                    {
                        SF.Argument(SF.ParseExpression($"{string.Join(", ", parameters)}")),
                    }
                );

                newMethod = newMethod.WithExpressionBody(SF.ArrowExpressionClause(SF.InvocationExpression(
                        call, SF.ArgumentList(callingArgs)
                        )
                    ));

                if (hadBody)
                    newMethod = newMethod.WithSemicolonToken(SF.Token(SyntaxKind.SemicolonToken));


                if (newMethod.HasLeadingTrivia)
                {
                    var trivia = newMethod.GetLeadingTrivia().ToList();
                    var (_, index) = trivia.Select((st, i) => (Token: st, Index: i)).Last(t =>
                        t.Token.IsKind(SyntaxKind.DocumentationCommentExteriorTrivia) ||
                        t.Token.IsKind(SyntaxKind.EndOfDocumentationCommentToken) ||
                        t.Token.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia) ||
                        t.Token.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                    );


                    newMethod = trivia.Count > index + 1 
                        ? newMethod.WithLeadingTrivia(trivia.Skip(index + 1)) 
                        : newMethod.WithLeadingTrivia(SF.Tab, SF.Tab);
                }


                writer.WriteLine(newMethod.ToFullString());
            }

            writer.WriteLine(@"    }
}");
        }

        private static string GetIdentifier(string @class, string instruction, MethodDeclarationSyntax method)
        {
            if (@class == "Sse" && instruction == "_mm_prefetch")
                return $"{instruction}{method.Identifier.Text[^1]}";

            else if (@class == "Avx" && (instruction == "_mm256_round_ps" || instruction == "_mm256_round_pd"))
                return $"{instruction}_{method.Identifier.Text}";

            else if (@class == "Sse41" && (instruction == "_mm_round_sd" || instruction == "_mm_round_ss"))
                return $"{instruction}_{method.Identifier.Text}";


            return instruction;
        }

        private static IList<(string Namespace, string Class, string Instruction, MethodDeclarationSyntax Method)> ProcessFolder(string dir)
        {
            var methods = new List<(string Namespace, string Class, string Instruction, MethodDeclarationSyntax Method)>();

            foreach (var file in Directory.EnumerateFiles(dir, "*.cs", SearchOption.AllDirectories))
            {
                var fileContent = File.ReadAllText(file);
                var tree = CSharpSyntaxTree.ParseText(fileContent);

                var syntaxRoot = tree.GetRoot();
                var classes = syntaxRoot.DescendantNodes()
                    .OfType<ClassDeclarationSyntax>()
                    .Where(c => c.AttributeLists.Any(
                        al => al.Attributes.Any(
                            a => a.Name is IdentifierNameSyntax ins && ins.Identifier.Text == "Intrinsic"
                        )
                    ));

                foreach (var @class in classes)
                {
                    var ns = @class.AncestorsAndSelf().OfType<NamespaceDeclarationSyntax>().Single().Name.ToString();

                    var containingClasses = @class.Ancestors().OfType<ClassDeclarationSyntax>().ToList();

                    bool isNested = containingClasses.Any();

                    var className = isNested
                        ? $"{string.Join(".", containingClasses.Select(c => c.Identifier.Text))}.{@class.Identifier.Text}"
                        : @class.Identifier.Text;

                    foreach (var method in @class.DescendantNodes()
                        .OfType<MethodDeclarationSyntax>()
                        .Where(m => m.Parent == @class)
                    )
                    {
                        if (method.HasLeadingTrivia && method.GetLeadingTrivia().ToString() is { } trivia &&
                              _instructionNamePattern.Match(trivia) is { } match &&
                              match.Groups["Instruction"] is { } grp && grp.Success && grp.ToString() is { } instr
                           )
                            methods.Add((ns, className, instr, method));
                        else
                            Console.Error.WriteLine($"Not handled: {className}.{method.Identifier.Text}");
                    }
                }
            }
            return methods;
        }
    }
}
