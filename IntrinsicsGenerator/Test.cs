using System.Linq;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using static Fast.Intrinsics;

namespace IntrinsicsGenerator
{
   static class Test
    {
        public static unsafe int SumVectorizedSse2()
        {
            var source = Enumerable.Range(0, 1024).Select(i => i).ToArray();
            int result;

            fixed (int* pSource = source)
            {
                var vecResult = System.Runtime.Intrinsics.Vector128<int>.Zero;

                int i = 0;
                int lastBlockIndex = source.Length - (source.Length % 4);

                while (i < lastBlockIndex)
                {
                    vecResult = _mm_add_epi32(vecResult, _mm_loadu_si128(pSource + i));
                    i += 4;
                }

                if (Ssse3.IsSupported)
                {
                    vecResult = _mm_hadd_epi32(vecResult, vecResult);
                    vecResult = _mm_hadd_epi32(vecResult, vecResult);
                }
                else
                {
                    vecResult = _mm_add_epi32(vecResult, _mm_shuffle_epi32(vecResult, 0x4E));
                    vecResult = _mm_add_epi32(vecResult, _mm_shuffle_epi32(vecResult, 0xB1));
                }
                result = vecResult.ToScalar();

                while (i < source.Length)
                {
                    result += pSource[i];
                    i += 1;
                }
            }

            return result;
        }
    }
}
