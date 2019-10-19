//GENERATED == DO NOT EDIT

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
    {
        public static Vector128<byte> _mm_aesdec_si128/*Aes.Decrypt*/(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.Decrypt(value, roundKey);

        public static Vector128<byte> _mm_aesdeclast_si128/*Aes.DecryptLast*/(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.DecryptLast(value, roundKey);

        public static Vector128<byte> _mm_aesenc_si128/*Aes.Encrypt*/(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.Encrypt(value, roundKey);

        public static Vector128<byte> _mm_aesenclast_si128/*Aes.EncryptLast*/(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.EncryptLast(value, roundKey);

        public static Vector128<byte> _mm_aesimc_si128/*Aes.InverseMixColumns*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Aes.InverseMixColumns(value);

        public static Vector128<byte> _mm_aeskeygenassist_si128/*Aes.KeygenAssist*/(Vector128<byte> value, byte control) => System.Runtime.Intrinsics.X86.Aes.KeygenAssist(value, control);

        public static Vector256<float> _mm256_add_ps/*Avx.Add*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Add(left, right);

        public static Vector256<double> _mm256_add_pd/*Avx.Add*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Add(left, right);

        public static Vector256<float> _mm256_addsub_ps/*Avx.AddSubtract*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.AddSubtract(left, right);

        public static Vector256<double> _mm256_addsub_pd/*Avx.AddSubtract*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.AddSubtract(left, right);

        public static Vector256<float> _mm256_and_ps/*Avx.And*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.And(left, right);

        public static Vector256<double> _mm256_and_pd/*Avx.And*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.And(left, right);

        public static Vector256<float> _mm256_andnot_ps/*Avx.AndNot*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.AndNot(left, right);

        public static Vector256<double> _mm256_andnot_pd/*Avx.AndNot*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.AndNot(left, right);

        public static Vector256<float> _mm256_blend_ps/*Avx.Blend*/(Vector256<float> left, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Blend(left, right, control);

        public static Vector256<double> _mm256_blend_pd/*Avx.Blend*/(Vector256<double> left, Vector256<double> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Blend(left, right, control);

        public static Vector256<float> _mm256_blendv_ps/*Avx.BlendVariable*/(Vector256<float> left, Vector256<float> right, Vector256<float> mask) => System.Runtime.Intrinsics.X86.Avx.BlendVariable(left, right, mask);

        public static Vector256<double> _mm256_blendv_pd/*Avx.BlendVariable*/(Vector256<double> left, Vector256<double> right, Vector256<double> mask) => System.Runtime.Intrinsics.X86.Avx.BlendVariable(left, right, mask);

        public static unsafe Vector128<float> _mm_broadcast_ss/*Avx.BroadcastScalarToVector128*/(float* source) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector128(source);

        public static unsafe Vector256<float> _mm256_broadcast_ss/*Avx.BroadcastScalarToVector256*/(float* source) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector256(source);

        public static unsafe Vector256<double> _mm256_broadcast_sd/*Avx.BroadcastScalarToVector256*/(double* source) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector256(source);

        public static unsafe Vector256<float> _mm256_broadcast_ps/*Avx.BroadcastVector128ToVector256*/(float* address) => System.Runtime.Intrinsics.X86.Avx.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<double> _mm256_broadcast_pd/*Avx.BroadcastVector128ToVector256*/(double* address) => System.Runtime.Intrinsics.X86.Avx.BroadcastVector128ToVector256(address);

        public static Vector256<float> _mm256_ceil_ps/*Avx.Ceiling*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Ceiling(value);

        public static Vector256<double> _mm256_ceil_pd/*Avx.Ceiling*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.Ceiling(value);

        public static Vector128<float> _mm_cmp_ps/*Avx.Compare*/(Vector128<float> left, Vector128<float> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector128<double> _mm_cmp_pd/*Avx.Compare*/(Vector128<double> left, Vector128<double> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector256<float> _mm256_cmp_ps/*Avx.Compare*/(Vector256<float> left, Vector256<float> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector256<double> _mm256_cmp_pd/*Avx.Compare*/(Vector256<double> left, Vector256<double> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector128<double> _mm_cmp_sd/*Avx.CompareScalar*/(Vector128<double> left, Vector128<double> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.CompareScalar(left, right, mode);

        public static Vector128<float> _mm_cmp_ss/*Avx.CompareScalar*/(Vector128<float> left, Vector128<float> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.CompareScalar(left, right, mode);

        public static Vector128<int> _mm256_cvtpd_epi32/*Avx.ConvertToVector128Int32*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Int32(value);

        public static Vector128<float> _mm256_cvtpd_ps/*Avx.ConvertToVector128Single*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Single(value);

        public static Vector256<int> _mm256_cvtps_epi32/*Avx.ConvertToVector256Int32*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Int32(value);

        public static Vector256<float> _mm256_cvtepi32_ps/*Avx.ConvertToVector256Single*/(Vector256<int> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Single(value);

        public static Vector256<double> _mm256_cvtps_pd/*Avx.ConvertToVector256Double*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Double(value);

        public static Vector256<double> _mm256_cvtepi32_pd/*Avx.ConvertToVector256Double*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Double(value);

        public static Vector128<int> _mm256_cvttpd_epi32/*Avx.ConvertToVector128Int32WithTruncation*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Int32WithTruncation(value);

        public static Vector256<int> _mm256_cvttps_epi32/*Avx.ConvertToVector256Int32WithTruncation*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Int32WithTruncation(value);

        public static Vector256<float> _mm256_div_ps/*Avx.Divide*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Divide(left, right);

        public static Vector256<double> _mm256_div_pd/*Avx.Divide*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Divide(left, right);

        public static Vector256<float> _mm256_dp_ps/*Avx.DotProduct*/(Vector256<float> left, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.DotProduct(left, right, control);

        public static Vector256<float> _mm256_moveldup_ps/*Avx.DuplicateEvenIndexed*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.DuplicateEvenIndexed(value);

        public static Vector256<double> _mm256_movedup_pd/*Avx.DuplicateEvenIndexed*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.DuplicateEvenIndexed(value);

        public static Vector256<float> _mm256_movehdup_ps/*Avx.DuplicateOddIndexed*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.DuplicateOddIndexed(value);

        public static Vector128<byte> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<byte> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<sbyte> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<sbyte> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<short> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<short> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<ushort> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<ushort> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<int> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<int> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<uint> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<uint> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<long> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<long> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<ulong> _mm256_extractf128_si256/*Avx.ExtractVector128*/(Vector256<ulong> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<float> _mm256_extractf128_ps/*Avx.ExtractVector128*/(Vector256<float> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<double> _mm256_extractf128_pd/*Avx.ExtractVector128*/(Vector256<double> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector256<float> _mm256_floor_ps/*Avx.Floor*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Floor(value);

        public static Vector256<double> _mm256_floor_pd/*Avx.Floor*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.Floor(value);

        public static Vector256<float> _mm256_hadd_ps/*Avx.HorizontalAdd*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalAdd(left, right);

        public static Vector256<double> _mm256_hadd_pd/*Avx.HorizontalAdd*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalAdd(left, right);

        public static Vector256<float> _mm256_hsub_ps/*Avx.HorizontalSubtract*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalSubtract(left, right);

        public static Vector256<double> _mm256_hsub_pd/*Avx.HorizontalSubtract*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalSubtract(left, right);

        public static Vector256<byte> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<byte> value, Vector128<byte> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<sbyte> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<sbyte> value, Vector128<sbyte> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<short> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<short> value, Vector128<short> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<ushort> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<ushort> value, Vector128<ushort> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<int> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<int> value, Vector128<int> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<uint> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<uint> value, Vector128<uint> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<long> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<long> value, Vector128<long> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<ulong> _mm256_insertf128_si256/*Avx.InsertVector128*/(Vector256<ulong> value, Vector128<ulong> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<float> _mm256_insertf128_ps/*Avx.InsertVector128*/(Vector256<float> value, Vector128<float> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<double> _mm256_insertf128_pd/*Avx.InsertVector128*/(Vector256<double> value, Vector128<double> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static unsafe Vector256<sbyte> _mm256_loadu_si256/*Avx.LoadVector256*/(sbyte* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<byte> _mm256_loadu_si256/*Avx.LoadVector256*/(byte* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<short> _mm256_loadu_si256/*Avx.LoadVector256*/(short* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<ushort> _mm256_loadu_si256/*Avx.LoadVector256*/(ushort* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<int> _mm256_loadu_si256/*Avx.LoadVector256*/(int* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<uint> _mm256_loadu_si256/*Avx.LoadVector256*/(uint* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<long> _mm256_loadu_si256/*Avx.LoadVector256*/(long* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<ulong> _mm256_loadu_si256/*Avx.LoadVector256*/(ulong* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<float> _mm256_loadu_ps/*Avx.LoadVector256*/(float* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<double> _mm256_loadu_pd/*Avx.LoadVector256*/(double* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<sbyte> _mm256_load_si256/*Avx.LoadAlignedVector256*/(sbyte* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<byte> _mm256_load_si256/*Avx.LoadAlignedVector256*/(byte* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<short> _mm256_load_si256/*Avx.LoadAlignedVector256*/(short* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<ushort> _mm256_load_si256/*Avx.LoadAlignedVector256*/(ushort* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<int> _mm256_load_si256/*Avx.LoadAlignedVector256*/(int* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<uint> _mm256_load_si256/*Avx.LoadAlignedVector256*/(uint* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<long> _mm256_load_si256/*Avx.LoadAlignedVector256*/(long* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<ulong> _mm256_load_si256/*Avx.LoadAlignedVector256*/(ulong* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<float> _mm256_load_ps/*Avx.LoadAlignedVector256*/(float* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<double> _mm256_load_pd/*Avx.LoadAlignedVector256*/(double* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<sbyte> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(sbyte* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<byte> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(byte* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<short> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(short* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<ushort> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(ushort* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<int> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(int* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<uint> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(uint* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<long> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(long* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<ulong> _mm256_lddqu_si256/*Avx.LoadDquVector256*/(ulong* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector128<float> _mm_maskload_ps/*Avx.MaskLoad*/(float* address, Vector128<float> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe Vector128<double> _mm_maskload_pd/*Avx.MaskLoad*/(double* address, Vector128<double> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe Vector256<float> _mm256_maskload_ps/*Avx.MaskLoad*/(float* address, Vector256<float> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe Vector256<double> _mm256_maskload_pd/*Avx.MaskLoad*/(double* address, Vector256<double> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe void _mm_maskstore_ps/*Avx.MaskStore*/(float* address, Vector128<float> mask, Vector128<float> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_pd/*Avx.MaskStore*/(double* address, Vector128<double> mask, Vector128<double> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_ps/*Avx.MaskStore*/(float* address, Vector256<float> mask, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_pd/*Avx.MaskStore*/(double* address, Vector256<double> mask, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static Vector256<float> _mm256_max_ps/*Avx.Max*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Max(left, right);

        public static Vector256<double> _mm256_max_pd/*Avx.Max*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Max(left, right);

        public static Vector256<float> _mm256_min_ps/*Avx.Min*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Min(left, right);

        public static Vector256<double> _mm256_min_pd/*Avx.Min*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Min(left, right);

        public static int _mm256_movemask_ps/*Avx.MoveMask*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.MoveMask(value);

        public static int _mm256_movemask_pd/*Avx.MoveMask*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.MoveMask(value);

        public static Vector256<float> _mm256_mul_ps/*Avx.Multiply*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Multiply(left, right);

        public static Vector256<double> _mm256_mul_pd/*Avx.Multiply*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Multiply(left, right);

        public static Vector256<float> _mm256_or_ps/*Avx.Or*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Or(left, right);

        public static Vector256<double> _mm256_or_pd/*Avx.Or*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Or(left, right);

        public static Vector128<float> _mm_permute_ps/*Avx.Permute*/(Vector128<float> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector128<double> _mm_permute_pd/*Avx.Permute*/(Vector128<double> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector256<float> _mm256_permute_ps/*Avx.Permute*/(Vector256<float> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector256<double> _mm256_permute_pd/*Avx.Permute*/(Vector256<double> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector256<byte> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<byte> left, Vector256<byte> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<sbyte> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<sbyte> left, Vector256<sbyte> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<short> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<short> left, Vector256<short> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<ushort> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<ushort> left, Vector256<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<int> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<int> left, Vector256<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<uint> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<uint> left, Vector256<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<long> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<long> left, Vector256<long> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<ulong> _mm256_permute2f128_si256/*Avx.Permute2x128*/(Vector256<ulong> left, Vector256<ulong> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<float> _mm256_permute2f128_ps/*Avx.Permute2x128*/(Vector256<float> left, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<double> _mm256_permute2f128_pd/*Avx.Permute2x128*/(Vector256<double> left, Vector256<double> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector128<float> _mm_permutevar_ps/*Avx.PermuteVar*/(Vector128<float> left, Vector128<int> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector128<double> _mm_permutevar_pd/*Avx.PermuteVar*/(Vector128<double> left, Vector128<long> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector256<float> _mm256_permutevar_ps/*Avx.PermuteVar*/(Vector256<float> left, Vector256<int> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector256<double> _mm256_permutevar_pd/*Avx.PermuteVar*/(Vector256<double> left, Vector256<long> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector256<float> _mm256_rcp_ps/*Avx.Reciprocal*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Reciprocal(value);

        public static Vector256<float> _mm256_rsqrt_ps/*Avx.ReciprocalSqrt*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.ReciprocalSqrt(value);

        public static Vector256<float> _mm256_round_ps_RoundToNearestInteger/*Avx.RoundToNearestInteger*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNearestInteger(value);

        public static Vector256<float> _mm256_round_ps_RoundToNegativeInfinity/*Avx.RoundToNegativeInfinity*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNegativeInfinity(value);

        public static Vector256<float> _mm256_round_ps_RoundToPositiveInfinity/*Avx.RoundToPositiveInfinity*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToPositiveInfinity(value);

        public static Vector256<float> _mm256_round_ps_RoundToZero/*Avx.RoundToZero*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToZero(value);

        public static Vector256<float> _mm256_round_ps_RoundCurrentDirection/*Avx.RoundCurrentDirection*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundCurrentDirection(value);

        public static Vector256<double> _mm256_round_pd_RoundToNearestInteger/*Avx.RoundToNearestInteger*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNearestInteger(value);

        public static Vector256<double> _mm256_round_pd_RoundToNegativeInfinity/*Avx.RoundToNegativeInfinity*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNegativeInfinity(value);

        public static Vector256<double> _mm256_round_pd_RoundToPositiveInfinity/*Avx.RoundToPositiveInfinity*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToPositiveInfinity(value);

        public static Vector256<double> _mm256_round_pd_RoundToZero/*Avx.RoundToZero*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToZero(value);

        public static Vector256<double> _mm256_round_pd_RoundCurrentDirection/*Avx.RoundCurrentDirection*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundCurrentDirection(value);

        public static Vector256<float> _mm256_shuffle_ps/*Avx.Shuffle*/(Vector256<float> value, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Shuffle(value, right, control);

        public static Vector256<double> _mm256_shuffle_pd/*Avx.Shuffle*/(Vector256<double> value, Vector256<double> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Shuffle(value, right, control);

        public static Vector256<float> _mm256_sqrt_ps/*Avx.Sqrt*/(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Sqrt(value);

        public static Vector256<double> _mm256_sqrt_pd/*Avx.Sqrt*/(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.Sqrt(value);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(sbyte* address, Vector256<sbyte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(byte* address, Vector256<byte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(short* address, Vector256<short> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(ushort* address, Vector256<ushort> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(int* address, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(uint* address, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(long* address, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256/*Avx.StoreAligned*/(ulong* address, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_ps/*Avx.StoreAligned*/(float* address, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_pd/*Avx.StoreAligned*/(double* address, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(sbyte* address, Vector256<sbyte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(byte* address, Vector256<byte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(short* address, Vector256<short> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(ushort* address, Vector256<ushort> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(int* address, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(uint* address, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(long* address, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256/*Avx.StoreAlignedNonTemporal*/(ulong* address, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_ps/*Avx.StoreAlignedNonTemporal*/(float* address, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_pd/*Avx.StoreAlignedNonTemporal*/(double* address, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(sbyte* address, Vector256<sbyte> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(byte* address, Vector256<byte> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(short* address, Vector256<short> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(ushort* address, Vector256<ushort> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(int* address, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(uint* address, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(long* address, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256/*Avx.Store*/(ulong* address, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_ps/*Avx.Store*/(float* address, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_pd/*Avx.Store*/(double* address, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static Vector256<float> _mm256_sub_ps/*Avx.Subtract*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Subtract(left, right);

        public static Vector256<double> _mm256_sub_pd/*Avx.Subtract*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Subtract(left, right);

        public static bool _mm_testc_ps/*Avx.TestC*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm_testc_pd/*Avx.TestC*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256/*Avx.TestC*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_ps/*Avx.TestC*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_pd/*Avx.TestC*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm_testnzc_ps/*Avx.TestNotZAndNotC*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm_testnzc_pd/*Avx.TestNotZAndNotC*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256/*Avx.TestNotZAndNotC*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_ps/*Avx.TestNotZAndNotC*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_pd/*Avx.TestNotZAndNotC*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm_testz_ps/*Avx.TestZ*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm_testz_pd/*Avx.TestZ*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256/*Avx.TestZ*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_ps/*Avx.TestZ*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_pd/*Avx.TestZ*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static Vector256<float> _mm256_unpackhi_ps/*Avx.UnpackHigh*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.UnpackHigh(left, right);

        public static Vector256<double> _mm256_unpackhi_pd/*Avx.UnpackHigh*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.UnpackHigh(left, right);

        public static Vector256<float> _mm256_unpacklo_ps/*Avx.UnpackLow*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.UnpackLow(left, right);

        public static Vector256<double> _mm256_unpacklo_pd/*Avx.UnpackLow*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.UnpackLow(left, right);

        public static Vector256<float> _mm256_xor_ps/*Avx.Xor*/(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Xor(left, right);

        public static Vector256<double> _mm256_xor_pd/*Avx.Xor*/(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Xor(left, right);

        public static Vector256<byte> _mm256_abs_epi8/*Avx2.Abs*/(Vector256<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.Abs(value);

        public static Vector256<ushort> _mm256_abs_epi16/*Avx2.Abs*/(Vector256<short> value) => System.Runtime.Intrinsics.X86.Avx2.Abs(value);

        public static Vector256<uint> _mm256_abs_epi32/*Avx2.Abs*/(Vector256<int> value) => System.Runtime.Intrinsics.X86.Avx2.Abs(value);

        public static Vector256<sbyte> _mm256_add_epi8/*Avx2.Add*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<byte> _mm256_add_epi8/*Avx2.Add*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<short> _mm256_add_epi16/*Avx2.Add*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<ushort> _mm256_add_epi16/*Avx2.Add*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<int> _mm256_add_epi32/*Avx2.Add*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<uint> _mm256_add_epi32/*Avx2.Add*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<long> _mm256_add_epi64/*Avx2.Add*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<ulong> _mm256_add_epi64/*Avx2.Add*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<sbyte> _mm256_adds_epi8/*Avx2.AddSaturate*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<byte> _mm256_adds_epu8/*Avx2.AddSaturate*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<short> _mm256_adds_epi16/*Avx2.AddSaturate*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<ushort> _mm256_adds_epu16/*Avx2.AddSaturate*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<sbyte> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<sbyte> left, Vector256<sbyte> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<byte> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<byte> left, Vector256<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<short> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<short> left, Vector256<short> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<ushort> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<ushort> left, Vector256<ushort> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<int> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<int> left, Vector256<int> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<uint> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<uint> left, Vector256<uint> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<long> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<long> left, Vector256<long> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<ulong> _mm256_alignr_epi8/*Avx2.AlignRight*/(Vector256<ulong> left, Vector256<ulong> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<sbyte> _mm256_and_si256/*Avx2.And*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<byte> _mm256_and_si256/*Avx2.And*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<short> _mm256_and_si256/*Avx2.And*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<ushort> _mm256_and_si256/*Avx2.And*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<int> _mm256_and_si256/*Avx2.And*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<uint> _mm256_and_si256/*Avx2.And*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<long> _mm256_and_si256/*Avx2.And*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<ulong> _mm256_and_si256/*Avx2.And*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<sbyte> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<byte> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<short> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<ushort> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<int> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<uint> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<long> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<ulong> _mm256_andnot_si256/*Avx2.AndNot*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<byte> _mm256_avg_epu8/*Avx2.Average*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Average(left, right);

        public static Vector256<ushort> _mm256_avg_epu16/*Avx2.Average*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Average(left, right);

        public static Vector128<int> _mm_blend_epi32/*Avx2.Blend*/(Vector128<int> left, Vector128<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector128<uint> _mm_blend_epi32/*Avx2.Blend*/(Vector128<uint> left, Vector128<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<short> _mm256_blend_epi16/*Avx2.Blend*/(Vector256<short> left, Vector256<short> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<ushort> _mm256_blend_epi16/*Avx2.Blend*/(Vector256<ushort> left, Vector256<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<int> _mm256_blend_epi32/*Avx2.Blend*/(Vector256<int> left, Vector256<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<uint> _mm256_blend_epi32/*Avx2.Blend*/(Vector256<uint> left, Vector256<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<sbyte> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<sbyte> left, Vector256<sbyte> right, Vector256<sbyte> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<byte> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<byte> left, Vector256<byte> right, Vector256<byte> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<short> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<short> left, Vector256<short> right, Vector256<short> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<ushort> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<ushort> left, Vector256<ushort> right, Vector256<ushort> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<int> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<int> left, Vector256<int> right, Vector256<int> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<uint> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<uint> left, Vector256<uint> right, Vector256<uint> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<long> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<long> left, Vector256<long> right, Vector256<long> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<ulong> _mm256_blendv_epi8/*Avx2.BlendVariable*/(Vector256<ulong> left, Vector256<ulong> right, Vector256<ulong> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector128<byte> _mm_broadcastb_epi8/*Avx2.BroadcastScalarToVector128*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<sbyte> _mm_broadcastb_epi8/*Avx2.BroadcastScalarToVector128*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<short> _mm_broadcastw_epi16/*Avx2.BroadcastScalarToVector128*/(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<ushort> _mm_broadcastw_epi16/*Avx2.BroadcastScalarToVector128*/(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<int> _mm_broadcastd_epi32/*Avx2.BroadcastScalarToVector128*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<uint> _mm_broadcastd_epi32/*Avx2.BroadcastScalarToVector128*/(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<long> _mm_broadcastq_epi64/*Avx2.BroadcastScalarToVector128*/(Vector128<long> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<ulong> _mm_broadcastq_epi64/*Avx2.BroadcastScalarToVector128*/(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<float> _mm_broadcastss_ps/*Avx2.BroadcastScalarToVector128*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<double> _mm_broadcastsd_pd/*Avx2.BroadcastScalarToVector128*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static unsafe Vector128<byte> _mm_broadcastb_epi8/*Avx2.BroadcastScalarToVector128*/(byte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<sbyte> _mm_broadcastb_epi8/*Avx2.BroadcastScalarToVector128*/(sbyte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<short> _mm_broadcastw_epi16/*Avx2.BroadcastScalarToVector128*/(short* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<ushort> _mm_broadcastw_epi16/*Avx2.BroadcastScalarToVector128*/(ushort* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<int> _mm_broadcastd_epi32/*Avx2.BroadcastScalarToVector128*/(int* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<uint> _mm_broadcastd_epi32/*Avx2.BroadcastScalarToVector128*/(uint* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<long> _mm_broadcastq_epi64/*Avx2.BroadcastScalarToVector128*/(long* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<ulong> _mm_broadcastq_epi64/*Avx2.BroadcastScalarToVector128*/(ulong* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static Vector256<byte> _mm256_broadcastb_epi8/*Avx2.BroadcastScalarToVector256*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<sbyte> _mm256_broadcastb_epi8/*Avx2.BroadcastScalarToVector256*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<short> _mm256_broadcastw_epi16/*Avx2.BroadcastScalarToVector256*/(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<ushort> _mm256_broadcastw_epi16/*Avx2.BroadcastScalarToVector256*/(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<int> _mm256_broadcastd_epi32/*Avx2.BroadcastScalarToVector256*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<uint> _mm256_broadcastd_epi32/*Avx2.BroadcastScalarToVector256*/(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<long> _mm256_broadcastq_epi64/*Avx2.BroadcastScalarToVector256*/(Vector128<long> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<ulong> _mm256_broadcastq_epi64/*Avx2.BroadcastScalarToVector256*/(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<float> _mm256_broadcastss_ps/*Avx2.BroadcastScalarToVector256*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<double> _mm256_broadcastsd_pd/*Avx2.BroadcastScalarToVector256*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static unsafe Vector256<byte> _mm256_broadcastb_epi8/*Avx2.BroadcastScalarToVector256*/(byte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<sbyte> _mm256_broadcastb_epi8/*Avx2.BroadcastScalarToVector256*/(sbyte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<short> _mm256_broadcastw_epi16/*Avx2.BroadcastScalarToVector256*/(short* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<ushort> _mm256_broadcastw_epi16/*Avx2.BroadcastScalarToVector256*/(ushort* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<int> _mm256_broadcastd_epi32/*Avx2.BroadcastScalarToVector256*/(int* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<uint> _mm256_broadcastd_epi32/*Avx2.BroadcastScalarToVector256*/(uint* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<long> _mm256_broadcastq_epi64/*Avx2.BroadcastScalarToVector256*/(long* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<ulong> _mm256_broadcastq_epi64/*Avx2.BroadcastScalarToVector256*/(ulong* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<sbyte> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(sbyte* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<byte> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(byte* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<short> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(short* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<ushort> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(ushort* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<int> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(int* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<uint> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(uint* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<long> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(long* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<ulong> _mm256_broadcastsi128_si256/*Avx2.BroadcastVector128ToVector256*/(ulong* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static Vector256<sbyte> _mm256_cmpeq_epi8/*Avx2.CompareEqual*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<byte> _mm256_cmpeq_epi8/*Avx2.CompareEqual*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<short> _mm256_cmpeq_epi16/*Avx2.CompareEqual*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<ushort> _mm256_cmpeq_epi16/*Avx2.CompareEqual*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<int> _mm256_cmpeq_epi32/*Avx2.CompareEqual*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<uint> _mm256_cmpeq_epi32/*Avx2.CompareEqual*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<long> _mm256_cmpeq_epi64/*Avx2.CompareEqual*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<ulong> _mm256_cmpeq_epi64/*Avx2.CompareEqual*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<sbyte> _mm256_cmpgt_epi8/*Avx2.CompareGreaterThan*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static Vector256<short> _mm256_cmpgt_epi16/*Avx2.CompareGreaterThan*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static Vector256<int> _mm256_cmpgt_epi32/*Avx2.CompareGreaterThan*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static Vector256<long> _mm256_cmpgt_epi64/*Avx2.CompareGreaterThan*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static int _mm256_cvtsi256_si32/*Avx2.ConvertToInt32*/(Vector256<int> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToInt32(value);

        public static uint _mm256_cvtsi256_si32/*Avx2.ConvertToUInt32*/(Vector256<uint> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToUInt32(value);

        public static Vector256<short> _mm256_cvtepi8_epi16/*Avx2.ConvertToVector256Int16*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int16(value);

        public static Vector256<short> _mm256_cvtepu8_epi16/*Avx2.ConvertToVector256Int16*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int16(value);

        public static Vector256<int> _mm256_cvtepi8_epi32/*Avx2.ConvertToVector256Int32*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<int> _mm256_cvtepu8_epi32/*Avx2.ConvertToVector256Int32*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<int> _mm256_cvtepi16_epi32/*Avx2.ConvertToVector256Int32*/(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<int> _mm256_cvtepu16_epi32/*Avx2.ConvertToVector256Int32*/(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<long> _mm256_cvtepi8_epi64/*Avx2.ConvertToVector256Int64*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepu8_epi64/*Avx2.ConvertToVector256Int64*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepi16_epi64/*Avx2.ConvertToVector256Int64*/(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepu16_epi64/*Avx2.ConvertToVector256Int64*/(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepi32_epi64/*Avx2.ConvertToVector256Int64*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepu32_epi64/*Avx2.ConvertToVector256Int64*/(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector128<sbyte> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<sbyte> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<byte> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<byte> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<short> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<short> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<ushort> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<ushort> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<int> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<int> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<uint> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<uint> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<long> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<long> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<ulong> _mm256_extracti128_si256/*Avx2.ExtractVector128*/(Vector256<ulong> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static unsafe Vector128<int> _mm_i32gather_epi32/*Avx2.GatherVector128*/(int* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<uint> _mm_i32gather_epi32/*Avx2.GatherVector128*/(uint* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<long> _mm_i32gather_epi64/*Avx2.GatherVector128*/(long* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<ulong> _mm_i32gather_epi64/*Avx2.GatherVector128*/(ulong* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<float> _mm_i32gather_ps/*Avx2.GatherVector128*/(float* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<double> _mm_i32gather_pd/*Avx2.GatherVector128*/(double* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<int> _mm_i64gather_epi32/*Avx2.GatherVector128*/(int* baseAddress, Vector128<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<uint> _mm_i64gather_epi32/*Avx2.GatherVector128*/(uint* baseAddress, Vector128<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<long> _mm_i64gather_epi64/*Avx2.GatherVector128*/(long* baseAddress, Vector128<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<ulong> _mm_i64gather_epi64/*Avx2.GatherVector128*/(ulong* baseAddress, Vector128<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<float> _mm_i64gather_ps/*Avx2.GatherVector128*/(float* baseAddress, Vector128<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<double> _mm_i64gather_pd/*Avx2.GatherVector128*/(double* baseAddress, Vector128<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector256<int> _mm256_i32gather_epi32/*Avx2.GatherVector256*/(int* baseAddress, Vector256<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<uint> _mm256_i32gather_epi32/*Avx2.GatherVector256*/(uint* baseAddress, Vector256<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<long> _mm256_i32gather_epi64/*Avx2.GatherVector256*/(long* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<ulong> _mm256_i32gather_epi64/*Avx2.GatherVector256*/(ulong* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<float> _mm256_i32gather_ps/*Avx2.GatherVector256*/(float* baseAddress, Vector256<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<double> _mm256_i32gather_pd/*Avx2.GatherVector256*/(double* baseAddress, Vector128<int> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector128<int> _mm256_i64gather_epi32/*Avx2.GatherVector128*/(int* baseAddress, Vector256<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<uint> _mm256_i64gather_epi32/*Avx2.GatherVector128*/(uint* baseAddress, Vector256<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector256<long> _mm256_i64gather_epi64/*Avx2.GatherVector256*/(long* baseAddress, Vector256<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<ulong> _mm256_i64gather_epi64/*Avx2.GatherVector256*/(ulong* baseAddress, Vector256<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector128<float> _mm256_i64gather_ps/*Avx2.GatherVector128*/(float* baseAddress, Vector256<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector256<double> _mm256_i64gather_pd/*Avx2.GatherVector256*/(double* baseAddress, Vector256<long> index, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector128<int> _mm_mask_i32gather_epi32/*Avx2.GatherMaskVector128*/(Vector128<int> source, int* baseAddress, Vector128<int> index, Vector128<int> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<uint> _mm_mask_i32gather_epi32/*Avx2.GatherMaskVector128*/(Vector128<uint> source, uint* baseAddress, Vector128<int> index, Vector128<uint> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<long> _mm_mask_i32gather_epi64/*Avx2.GatherMaskVector128*/(Vector128<long> source, long* baseAddress, Vector128<int> index, Vector128<long> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<ulong> _mm_mask_i32gather_epi64/*Avx2.GatherMaskVector128*/(Vector128<ulong> source, ulong* baseAddress, Vector128<int> index, Vector128<ulong> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<float> _mm_mask_i32gather_ps/*Avx2.GatherMaskVector128*/(Vector128<float> source, float* baseAddress, Vector128<int> index, Vector128<float> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<double> _mm_mask_i32gather_pd/*Avx2.GatherMaskVector128*/(Vector128<double> source, double* baseAddress, Vector128<int> index, Vector128<double> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<int> _mm_mask_i64gather_epi32/*Avx2.GatherMaskVector128*/(Vector128<int> source, int* baseAddress, Vector128<long> index, Vector128<int> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<uint> _mm_mask_i64gather_epi32/*Avx2.GatherMaskVector128*/(Vector128<uint> source, uint* baseAddress, Vector128<long> index, Vector128<uint> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<long> _mm_mask_i64gather_epi64/*Avx2.GatherMaskVector128*/(Vector128<long> source, long* baseAddress, Vector128<long> index, Vector128<long> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<ulong> _mm_mask_i64gather_epi64/*Avx2.GatherMaskVector128*/(Vector128<ulong> source, ulong* baseAddress, Vector128<long> index, Vector128<ulong> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<float> _mm_mask_i64gather_ps/*Avx2.GatherMaskVector128*/(Vector128<float> source, float* baseAddress, Vector128<long> index, Vector128<float> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<double> _mm_mask_i64gather_pd/*Avx2.GatherMaskVector128*/(Vector128<double> source, double* baseAddress, Vector128<long> index, Vector128<double> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<int> _mm256_mask_i32gather_epi32/*Avx2.GatherMaskVector256*/(Vector256<int> source, int* baseAddress, Vector256<int> index, Vector256<int> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<uint> _mm256_mask_i32gather_epi32/*Avx2.GatherMaskVector256*/(Vector256<uint> source, uint* baseAddress, Vector256<int> index, Vector256<uint> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<long> _mm256_mask_i32gather_epi64/*Avx2.GatherMaskVector256*/(Vector256<long> source, long* baseAddress, Vector128<int> index, Vector256<long> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<ulong> _mm256_mask_i32gather_epi64/*Avx2.GatherMaskVector256*/(Vector256<ulong> source, ulong* baseAddress, Vector128<int> index, Vector256<ulong> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<float> _mm256_mask_i32gather_ps/*Avx2.GatherMaskVector256*/(Vector256<float> source, float* baseAddress, Vector256<int> index, Vector256<float> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<double> _mm256_mask_i32gather_pd/*Avx2.GatherMaskVector256*/(Vector256<double> source, double* baseAddress, Vector128<int> index, Vector256<double> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<int> _mm256_mask_i64gather_epi32/*Avx2.GatherMaskVector128*/(Vector128<int> source, int* baseAddress, Vector256<long> index, Vector128<int> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<uint> _mm256_mask_i64gather_epi32/*Avx2.GatherMaskVector128*/(Vector128<uint> source, uint* baseAddress, Vector256<long> index, Vector128<uint> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<long> _mm256_mask_i64gather_epi64/*Avx2.GatherMaskVector256*/(Vector256<long> source, long* baseAddress, Vector256<long> index, Vector256<long> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<ulong> _mm256_mask_i64gather_epi64/*Avx2.GatherMaskVector256*/(Vector256<ulong> source, ulong* baseAddress, Vector256<long> index, Vector256<ulong> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<float> _mm256_mask_i64gather_ps/*Avx2.GatherMaskVector128*/(Vector128<float> source, float* baseAddress, Vector256<long> index, Vector128<float> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<double> _mm256_mask_i64gather_pd/*Avx2.GatherMaskVector256*/(Vector256<double> source, double* baseAddress, Vector256<long> index, Vector256<double> mask, byte scale)
=> System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static Vector256<short> _mm256_hadd_epi16/*Avx2.HorizontalAdd*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAdd(left, right);

        public static Vector256<int> _mm256_hadd_epi32/*Avx2.HorizontalAdd*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAdd(left, right);

        public static Vector256<short> _mm256_hadds_epi16/*Avx2.HorizontalAddSaturate*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAddSaturate(left, right);

        public static Vector256<short> _mm256_hsub_epi16/*Avx2.HorizontalSubtract*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtract(left, right);

        public static Vector256<int> _mm256_hsub_epi32/*Avx2.HorizontalSubtract*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtract(left, right);

        public static Vector256<short> _mm256_hsubs_epi16/*Avx2.HorizontalSubtractSaturate*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtractSaturate(left, right);

        public static Vector256<sbyte> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<sbyte> value, Vector128<sbyte> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<byte> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<byte> value, Vector128<byte> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<short> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<short> value, Vector128<short> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<ushort> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<ushort> value, Vector128<ushort> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<int> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<int> value, Vector128<int> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<uint> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<uint> value, Vector128<uint> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<long> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<long> value, Vector128<long> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<ulong> _mm256_inserti128_si256/*Avx2.InsertVector128*/(Vector256<ulong> value, Vector128<ulong> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static unsafe Vector256<sbyte> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(sbyte* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<byte> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(byte* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<short> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(short* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<ushort> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(ushort* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<int> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(int* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<uint> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(uint* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<long> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(long* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<ulong> _mm256_stream_load_si256/*Avx2.LoadAlignedVector256NonTemporal*/(ulong* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector128<int> _mm_maskload_epi32/*Avx2.MaskLoad*/(int* address, Vector128<int> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector128<uint> _mm_maskload_epi32/*Avx2.MaskLoad*/(uint* address, Vector128<uint> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector128<long> _mm_maskload_epi64/*Avx2.MaskLoad*/(long* address, Vector128<long> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector128<ulong> _mm_maskload_epi64/*Avx2.MaskLoad*/(ulong* address, Vector128<ulong> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<int> _mm256_maskload_epi32/*Avx2.MaskLoad*/(int* address, Vector256<int> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<uint> _mm256_maskload_epi32/*Avx2.MaskLoad*/(uint* address, Vector256<uint> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<long> _mm256_maskload_epi64/*Avx2.MaskLoad*/(long* address, Vector256<long> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<ulong> _mm256_maskload_epi64/*Avx2.MaskLoad*/(ulong* address, Vector256<ulong> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe void _mm_maskstore_epi32/*Avx2.MaskStore*/(int* address, Vector128<int> mask, Vector128<int> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_epi32/*Avx2.MaskStore*/(uint* address, Vector128<uint> mask, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_epi64/*Avx2.MaskStore*/(long* address, Vector128<long> mask, Vector128<long> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_epi64/*Avx2.MaskStore*/(ulong* address, Vector128<ulong> mask, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi32/*Avx2.MaskStore*/(int* address, Vector256<int> mask, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi32/*Avx2.MaskStore*/(uint* address, Vector256<uint> mask, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi64/*Avx2.MaskStore*/(long* address, Vector256<long> mask, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi64/*Avx2.MaskStore*/(ulong* address, Vector256<ulong> mask, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static Vector256<int> _mm256_madd_epi16/*Avx2.MultiplyAddAdjacent*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyAddAdjacent(left, right);

        public static Vector256<short> _mm256_maddubs_epi16/*Avx2.MultiplyAddAdjacent*/(Vector256<byte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyAddAdjacent(left, right);

        public static Vector256<sbyte> _mm256_max_epi8/*Avx2.Max*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<byte> _mm256_max_epu8/*Avx2.Max*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<short> _mm256_max_epi16/*Avx2.Max*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<ushort> _mm256_max_epu16/*Avx2.Max*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<int> _mm256_max_epi32/*Avx2.Max*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<uint> _mm256_max_epu32/*Avx2.Max*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<sbyte> _mm256_min_epi8/*Avx2.Min*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<byte> _mm256_min_epu8/*Avx2.Min*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<short> _mm256_min_epi16/*Avx2.Min*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<ushort> _mm256_min_epu16/*Avx2.Min*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<int> _mm256_min_epi32/*Avx2.Min*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<uint> _mm256_min_epu32/*Avx2.Min*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static int _mm256_movemask_epi8/*Avx2.MoveMask*/(Vector256<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.MoveMask(value);

        public static int _mm256_movemask_epi8/*Avx2.MoveMask*/(Vector256<byte> value) => System.Runtime.Intrinsics.X86.Avx2.MoveMask(value);

        public static Vector256<ushort> _mm256_mpsadbw_epu8/*Avx2.MultipleSumAbsoluteDifferences*/(Vector256<byte> left, Vector256<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.MultipleSumAbsoluteDifferences(left, right, mask);

        public static Vector256<long> _mm256_mul_epi32/*Avx2.Multiply*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Multiply(left, right);

        public static Vector256<ulong> _mm256_mul_epu32/*Avx2.Multiply*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Multiply(left, right);

        public static Vector256<short> _mm256_mulhi_epi16/*Avx2.MultiplyHigh*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHigh(left, right);

        public static Vector256<ushort> _mm256_mulhi_epu16/*Avx2.MultiplyHigh*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHigh(left, right);

        public static Vector256<short> _mm256_mulhrs_epi16/*Avx2.MultiplyHighRoundScale*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHighRoundScale(left, right);

        public static Vector256<short> _mm256_mullo_epi16/*Avx2.MultiplyLow*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<ushort> _mm256_mullo_epi16/*Avx2.MultiplyLow*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<int> _mm256_mullo_epi32/*Avx2.MultiplyLow*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<uint> _mm256_mullo_epi32/*Avx2.MultiplyLow*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<sbyte> _mm256_or_si256/*Avx2.Or*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<byte> _mm256_or_si256/*Avx2.Or*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<short> _mm256_or_si256/*Avx2.Or*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<ushort> _mm256_or_si256/*Avx2.Or*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<int> _mm256_or_si256/*Avx2.Or*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<uint> _mm256_or_si256/*Avx2.Or*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<long> _mm256_or_si256/*Avx2.Or*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<ulong> _mm256_or_si256/*Avx2.Or*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<sbyte> _mm256_packs_epi16/*Avx2.PackSignedSaturate*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.PackSignedSaturate(left, right);

        public static Vector256<short> _mm256_packs_epi32/*Avx2.PackSignedSaturate*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.PackSignedSaturate(left, right);

        public static Vector256<byte> _mm256_packus_epi16/*Avx2.PackUnsignedSaturate*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.PackUnsignedSaturate(left, right);

        public static Vector256<ushort> _mm256_packus_epi32/*Avx2.PackUnsignedSaturate*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.PackUnsignedSaturate(left, right);

        public static Vector256<sbyte> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<sbyte> left, Vector256<sbyte> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<byte> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<byte> left, Vector256<byte> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<short> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<short> left, Vector256<short> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<ushort> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<ushort> left, Vector256<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<int> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<int> left, Vector256<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<uint> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<uint> left, Vector256<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<long> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<long> left, Vector256<long> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<ulong> _mm256_permute2x128_si256/*Avx2.Permute2x128*/(Vector256<ulong> left, Vector256<ulong> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<long> _mm256_permute4x64_epi64/*Avx2.Permute4x64*/(Vector256<long> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(value, control);

        public static Vector256<ulong> _mm256_permute4x64_epi64/*Avx2.Permute4x64*/(Vector256<ulong> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(value, control);

        public static Vector256<double> _mm256_permute4x64_pd/*Avx2.Permute4x64*/(Vector256<double> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(value, control);

        public static Vector256<int> _mm256_permutevar8x32_epi32/*Avx2.PermuteVar8x32*/(Vector256<int> left, Vector256<int> control) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(left, control);

        public static Vector256<uint> _mm256_permutevar8x32_epi32/*Avx2.PermuteVar8x32*/(Vector256<uint> left, Vector256<uint> control) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(left, control);

        public static Vector256<float> _mm256_permutevar8x32_ps/*Avx2.PermuteVar8x32*/(Vector256<float> left, Vector256<int> control) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(left, control);

        public static Vector256<short> _mm256_sll_epi16/*Avx2.ShiftLeftLogical*/(Vector256<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ushort> _mm256_sll_epi16/*Avx2.ShiftLeftLogical*/(Vector256<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<int> _mm256_sll_epi32/*Avx2.ShiftLeftLogical*/(Vector256<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<uint> _mm256_sll_epi32/*Avx2.ShiftLeftLogical*/(Vector256<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<long> _mm256_sll_epi64/*Avx2.ShiftLeftLogical*/(Vector256<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ulong> _mm256_sll_epi64/*Avx2.ShiftLeftLogical*/(Vector256<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<short> _mm256_slli_epi16/*Avx2.ShiftLeftLogical*/(Vector256<short> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ushort> _mm256_slli_epi16/*Avx2.ShiftLeftLogical*/(Vector256<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<int> _mm256_slli_epi32/*Avx2.ShiftLeftLogical*/(Vector256<int> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<uint> _mm256_slli_epi32/*Avx2.ShiftLeftLogical*/(Vector256<uint> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<long> _mm256_slli_epi64/*Avx2.ShiftLeftLogical*/(Vector256<long> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ulong> _mm256_slli_epi64/*Avx2.ShiftLeftLogical*/(Vector256<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<sbyte> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<byte> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<short> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<ushort> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<uint> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<long> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<ulong> _mm256_bslli_epi128/*Avx2.ShiftLeftLogical128BitLane*/(Vector256<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_sllv_epi32/*Avx2.ShiftLeftLogicalVariable*/(Vector256<int> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<uint> _mm256_sllv_epi32/*Avx2.ShiftLeftLogicalVariable*/(Vector256<uint> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<long> _mm256_sllv_epi64/*Avx2.ShiftLeftLogicalVariable*/(Vector256<long> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<ulong> _mm256_sllv_epi64/*Avx2.ShiftLeftLogicalVariable*/(Vector256<ulong> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<int> _mm_sllv_epi32/*Avx2.ShiftLeftLogicalVariable*/(Vector128<int> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<uint> _mm_sllv_epi32/*Avx2.ShiftLeftLogicalVariable*/(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<long> _mm_sllv_epi64/*Avx2.ShiftLeftLogicalVariable*/(Vector128<long> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<ulong> _mm_sllv_epi64/*Avx2.ShiftLeftLogicalVariable*/(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<short> _mm256_sra_epi16/*Avx2.ShiftRightArithmetic*/(Vector256<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<int> _mm256_sra_epi32/*Avx2.ShiftRightArithmetic*/(Vector256<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<short> _mm256_srai_epi16/*Avx2.ShiftRightArithmetic*/(Vector256<short> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<int> _mm256_srai_epi32/*Avx2.ShiftRightArithmetic*/(Vector256<int> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<int> _mm256_srav_epi32/*Avx2.ShiftRightArithmeticVariable*/(Vector256<int> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmeticVariable(value, count);

        public static Vector128<int> _mm_srav_epi32/*Avx2.ShiftRightArithmeticVariable*/(Vector128<int> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmeticVariable(value, count);

        public static Vector256<short> _mm256_srl_epi16/*Avx2.ShiftRightLogical*/(Vector256<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ushort> _mm256_srl_epi16/*Avx2.ShiftRightLogical*/(Vector256<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<int> _mm256_srl_epi32/*Avx2.ShiftRightLogical*/(Vector256<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<uint> _mm256_srl_epi32/*Avx2.ShiftRightLogical*/(Vector256<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<long> _mm256_srl_epi64/*Avx2.ShiftRightLogical*/(Vector256<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ulong> _mm256_srl_epi64/*Avx2.ShiftRightLogical*/(Vector256<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<short> _mm256_srli_epi16/*Avx2.ShiftRightLogical*/(Vector256<short> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ushort> _mm256_srli_epi16/*Avx2.ShiftRightLogical*/(Vector256<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<int> _mm256_srli_epi32/*Avx2.ShiftRightLogical*/(Vector256<int> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<uint> _mm256_srli_epi32/*Avx2.ShiftRightLogical*/(Vector256<uint> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<long> _mm256_srli_epi64/*Avx2.ShiftRightLogical*/(Vector256<long> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ulong> _mm256_srli_epi64/*Avx2.ShiftRightLogical*/(Vector256<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<sbyte> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<byte> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<short> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<ushort> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<uint> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<long> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<ulong> _mm256_bsrli_epi128/*Avx2.ShiftRightLogical128BitLane*/(Vector256<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_srlv_epi32/*Avx2.ShiftRightLogicalVariable*/(Vector256<int> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<uint> _mm256_srlv_epi32/*Avx2.ShiftRightLogicalVariable*/(Vector256<uint> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<long> _mm256_srlv_epi64/*Avx2.ShiftRightLogicalVariable*/(Vector256<long> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<ulong> _mm256_srlv_epi64/*Avx2.ShiftRightLogicalVariable*/(Vector256<ulong> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<int> _mm_srlv_epi32/*Avx2.ShiftRightLogicalVariable*/(Vector128<int> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<uint> _mm_srlv_epi32/*Avx2.ShiftRightLogicalVariable*/(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<long> _mm_srlv_epi64/*Avx2.ShiftRightLogicalVariable*/(Vector128<long> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<ulong> _mm_srlv_epi64/*Avx2.ShiftRightLogicalVariable*/(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<sbyte> _mm256_shuffle_epi8/*Avx2.Shuffle*/(Vector256<sbyte> value, Vector256<sbyte> mask) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, mask);

        public static Vector256<byte> _mm256_shuffle_epi8/*Avx2.Shuffle*/(Vector256<byte> value, Vector256<byte> mask) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, mask);

        public static Vector256<int> _mm256_shuffle_epi32/*Avx2.Shuffle*/(Vector256<int> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, control);

        public static Vector256<uint> _mm256_shuffle_epi32/*Avx2.Shuffle*/(Vector256<uint> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, control);

        public static Vector256<short> _mm256_shufflehi_epi16/*Avx2.ShuffleHigh*/(Vector256<short> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleHigh(value, control);

        public static Vector256<ushort> _mm256_shufflehi_epi16/*Avx2.ShuffleHigh*/(Vector256<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleHigh(value, control);

        public static Vector256<short> _mm256_shufflelo_epi16/*Avx2.ShuffleLow*/(Vector256<short> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleLow(value, control);

        public static Vector256<ushort> _mm256_shufflelo_epi16/*Avx2.ShuffleLow*/(Vector256<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleLow(value, control);

        public static Vector256<sbyte> _mm256_sign_epi8/*Avx2.Sign*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Sign(left, right);

        public static Vector256<short> _mm256_sign_epi16/*Avx2.Sign*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Sign(left, right);

        public static Vector256<int> _mm256_sign_epi32/*Avx2.Sign*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Sign(left, right);

        public static Vector256<sbyte> _mm256_sub_epi8/*Avx2.Subtract*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<byte> _mm256_sub_epi8/*Avx2.Subtract*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<short> _mm256_sub_epi16/*Avx2.Subtract*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<ushort> _mm256_sub_epi16/*Avx2.Subtract*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<int> _mm256_sub_epi32/*Avx2.Subtract*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<uint> _mm256_sub_epi32/*Avx2.Subtract*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<long> _mm256_sub_epi64/*Avx2.Subtract*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<ulong> _mm256_sub_epi64/*Avx2.Subtract*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<sbyte> _mm256_subs_epi8/*Avx2.SubtractSaturate*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<short> _mm256_subs_epi16/*Avx2.SubtractSaturate*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<byte> _mm256_subs_epu8/*Avx2.SubtractSaturate*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<ushort> _mm256_subs_epu16/*Avx2.SubtractSaturate*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<ushort> _mm256_sad_epu8/*Avx2.SumAbsoluteDifferences*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.SumAbsoluteDifferences(left, right);

        public static Vector256<sbyte> _mm256_unpackhi_epi8/*Avx2.UnpackHigh*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<byte> _mm256_unpackhi_epi8/*Avx2.UnpackHigh*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<short> _mm256_unpackhi_epi16/*Avx2.UnpackHigh*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<ushort> _mm256_unpackhi_epi16/*Avx2.UnpackHigh*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<int> _mm256_unpackhi_epi32/*Avx2.UnpackHigh*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<uint> _mm256_unpackhi_epi32/*Avx2.UnpackHigh*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<long> _mm256_unpackhi_epi64/*Avx2.UnpackHigh*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<ulong> _mm256_unpackhi_epi64/*Avx2.UnpackHigh*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<sbyte> _mm256_unpacklo_epi8/*Avx2.UnpackLow*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<byte> _mm256_unpacklo_epi8/*Avx2.UnpackLow*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<short> _mm256_unpacklo_epi16/*Avx2.UnpackLow*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<ushort> _mm256_unpacklo_epi16/*Avx2.UnpackLow*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<int> _mm256_unpacklo_epi32/*Avx2.UnpackLow*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<uint> _mm256_unpacklo_epi32/*Avx2.UnpackLow*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<long> _mm256_unpacklo_epi64/*Avx2.UnpackLow*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<ulong> _mm256_unpacklo_epi64/*Avx2.UnpackLow*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<sbyte> _mm256_xor_si256/*Avx2.Xor*/(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<byte> _mm256_xor_si256/*Avx2.Xor*/(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<short> _mm256_xor_si256/*Avx2.Xor*/(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<ushort> _mm256_xor_si256/*Avx2.Xor*/(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<int> _mm256_xor_si256/*Avx2.Xor*/(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<uint> _mm256_xor_si256/*Avx2.Xor*/(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<long> _mm256_xor_si256/*Avx2.Xor*/(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<ulong> _mm256_xor_si256/*Avx2.Xor*/(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static uint _andn_u32/*Bmi1.AndNot*/(uint left, uint right) => System.Runtime.Intrinsics.X86.Bmi1.AndNot(left, right);

        public static uint _bextr_u32/*Bmi1.BitFieldExtract*/(uint value, byte start, byte length) => System.Runtime.Intrinsics.X86.Bmi1.BitFieldExtract(value, start, length);

        public static uint _bextr2_u32/*Bmi1.BitFieldExtract*/(uint value, ushort control) => System.Runtime.Intrinsics.X86.Bmi1.BitFieldExtract(value, control);

        public static uint _blsi_u32/*Bmi1.ExtractLowestSetBit*/(uint value) => System.Runtime.Intrinsics.X86.Bmi1.ExtractLowestSetBit(value);

        public static uint _blsmsk_u32/*Bmi1.GetMaskUpToLowestSetBit*/(uint value) => System.Runtime.Intrinsics.X86.Bmi1.GetMaskUpToLowestSetBit(value);

        public static uint _blsr_u32/*Bmi1.ResetLowestSetBit*/(uint value) => System.Runtime.Intrinsics.X86.Bmi1.ResetLowestSetBit(value);

        public static uint _mm_tzcnt_32/*Bmi1.TrailingZeroCount*/(uint value) => System.Runtime.Intrinsics.X86.Bmi1.TrailingZeroCount(value);

        public static ulong _andn_u64/*Bmi1.X64.AndNot*/(ulong left, ulong right) => System.Runtime.Intrinsics.X86.Bmi1.X64.AndNot(left, right);

        public static ulong _bextr_u64/*Bmi1.X64.BitFieldExtract*/(ulong value, byte start, byte length) => System.Runtime.Intrinsics.X86.Bmi1.X64.BitFieldExtract(value, start, length);

        public static ulong _bextr2_u64/*Bmi1.X64.BitFieldExtract*/(ulong value, ushort control) => System.Runtime.Intrinsics.X86.Bmi1.X64.BitFieldExtract(value, control);

        public static ulong _blsi_u64/*Bmi1.X64.ExtractLowestSetBit*/(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.ExtractLowestSetBit(value);

        public static ulong _blsmsk_u64/*Bmi1.X64.GetMaskUpToLowestSetBit*/(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.GetMaskUpToLowestSetBit(value);

        public static ulong _blsr_u64/*Bmi1.X64.ResetLowestSetBit*/(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.ResetLowestSetBit(value);

        public static ulong _mm_tzcnt_64/*Bmi1.X64.TrailingZeroCount*/(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.TrailingZeroCount(value);

        public static uint _bzhi_u32/*Bmi2.ZeroHighBits*/(uint value, uint index) => System.Runtime.Intrinsics.X86.Bmi2.ZeroHighBits(value, index);

        public static uint _mulx_u32/*Bmi2.MultiplyNoFlags*/(uint left, uint right) => System.Runtime.Intrinsics.X86.Bmi2.MultiplyNoFlags(left, right);

        public static unsafe uint _mulx_u32/*Bmi2.MultiplyNoFlags*/(uint left, uint right, uint* low) => System.Runtime.Intrinsics.X86.Bmi2.MultiplyNoFlags(left, right, low);

        public static uint _pdep_u32/*Bmi2.ParallelBitDeposit*/(uint value, uint mask) => System.Runtime.Intrinsics.X86.Bmi2.ParallelBitDeposit(value, mask);

        public static uint _pext_u32/*Bmi2.ParallelBitExtract*/(uint value, uint mask) => System.Runtime.Intrinsics.X86.Bmi2.ParallelBitExtract(value, mask);

        public static ulong _bzhi_u64/*Bmi2.X64.ZeroHighBits*/(ulong value, ulong index) => System.Runtime.Intrinsics.X86.Bmi2.X64.ZeroHighBits(value, index);

        public static ulong _mulx_u64/*Bmi2.X64.MultiplyNoFlags*/(ulong left, ulong right) => System.Runtime.Intrinsics.X86.Bmi2.X64.MultiplyNoFlags(left, right);

        public static unsafe ulong _mulx_u64/*Bmi2.X64.MultiplyNoFlags*/(ulong left, ulong right, ulong* low) => System.Runtime.Intrinsics.X86.Bmi2.X64.MultiplyNoFlags(left, right, low);

        public static ulong _pdep_u64/*Bmi2.X64.ParallelBitDeposit*/(ulong value, ulong mask) => System.Runtime.Intrinsics.X86.Bmi2.X64.ParallelBitDeposit(value, mask);

        public static ulong _pext_u64/*Bmi2.X64.ParallelBitExtract*/(ulong value, ulong mask) => System.Runtime.Intrinsics.X86.Bmi2.X64.ParallelBitExtract(value, mask);

        public static Vector128<float> _mm_fmadd_ps/*Fma.MultiplyAdd*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector128<double> _mm_fmadd_pd/*Fma.MultiplyAdd*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector256<float> _mm256_fmadd_ps/*Fma.MultiplyAdd*/(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector256<double> _mm256_fmadd_pd/*Fma.MultiplyAdd*/(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector128<float> _mm_fmadd_ss/*Fma.MultiplyAddScalar*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddScalar(a, b, c);

        public static Vector128<double> _mm_fmadd_sd/*Fma.MultiplyAddScalar*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddScalar(a, b, c);

        public static Vector128<float> _mm_fmaddsub_ps/*Fma.MultiplyAddSubtract*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector128<double> _mm_fmaddsub_pd/*Fma.MultiplyAddSubtract*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector256<float> _mm256_fmaddsub_ps/*Fma.MultiplyAddSubtract*/(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector256<double> _mm256_fmaddsub_pd/*Fma.MultiplyAddSubtract*/(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector128<float> _mm_fmsub_ps/*Fma.MultiplySubtract*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector128<double> _mm_fmsub_pd/*Fma.MultiplySubtract*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector256<float> _mm256_fmsub_ps/*Fma.MultiplySubtract*/(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector256<double> _mm256_fmsub_pd/*Fma.MultiplySubtract*/(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector128<float> _mm_fmsub_ss/*Fma.MultiplySubtractScalar*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractScalar(a, b, c);

        public static Vector128<double> _mm_fmsub_sd/*Fma.MultiplySubtractScalar*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractScalar(a, b, c);

        public static Vector128<float> _mm_fmsubadd_ps/*Fma.MultiplySubtractAdd*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector128<double> _mm_fmsubadd_pd/*Fma.MultiplySubtractAdd*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector256<float> _mm256_fmsubadd_ps/*Fma.MultiplySubtractAdd*/(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector256<double> _mm256_fmsubadd_pd/*Fma.MultiplySubtractAdd*/(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector128<float> _mm_fnmadd_ps/*Fma.MultiplyAddNegated*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector128<double> _mm_fnmadd_pd/*Fma.MultiplyAddNegated*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector256<float> _mm256_fnmadd_ps/*Fma.MultiplyAddNegated*/(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector256<double> _mm256_fnmadd_pd/*Fma.MultiplyAddNegated*/(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector128<float> _mm_fnmadd_ss/*Fma.MultiplyAddNegatedScalar*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegatedScalar(a, b, c);

        public static Vector128<double> _mm_fnmadd_sd/*Fma.MultiplyAddNegatedScalar*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegatedScalar(a, b, c);

        public static Vector128<float> _mm_fnmsub_ps/*Fma.MultiplySubtractNegated*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector128<double> _mm_fnmsub_pd/*Fma.MultiplySubtractNegated*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector256<float> _mm256_fnmsub_ps/*Fma.MultiplySubtractNegated*/(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector256<double> _mm256_fnmsub_pd/*Fma.MultiplySubtractNegated*/(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector128<float> _mm_fnmsub_ss/*Fma.MultiplySubtractNegatedScalar*/(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegatedScalar(a, b, c);

        public static Vector128<double> _mm_fnmsub_sd/*Fma.MultiplySubtractNegatedScalar*/(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegatedScalar(a, b, c);

        public static uint _lzcnt_u32/*Lzcnt.LeadingZeroCount*/(uint value) => System.Runtime.Intrinsics.X86.Lzcnt.LeadingZeroCount(value);

        public static ulong _lzcnt_u64/*Lzcnt.X64.LeadingZeroCount*/(ulong value) => System.Runtime.Intrinsics.X86.Lzcnt.X64.LeadingZeroCount(value);

        public static Vector128<long> _mm_clmulepi64_si128/*Pclmulqdq.CarrylessMultiply*/(Vector128<long> left, Vector128<long> right, byte control) => System.Runtime.Intrinsics.X86.Pclmulqdq.CarrylessMultiply(left, right, control);

        public static Vector128<ulong> _mm_clmulepi64_si128/*Pclmulqdq.CarrylessMultiply*/(Vector128<ulong> left, Vector128<ulong> right, byte control) => System.Runtime.Intrinsics.X86.Pclmulqdq.CarrylessMultiply(left, right, control);

        public static uint _mm_popcnt_u32/*Popcnt.PopCount*/(uint value) => System.Runtime.Intrinsics.X86.Popcnt.PopCount(value);

        public static ulong _mm_popcnt_u64/*Popcnt.X64.PopCount*/(ulong value) => System.Runtime.Intrinsics.X86.Popcnt.X64.PopCount(value);

        public static Vector128<float> _mm_add_ps/*Sse.Add*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Add(left, right);

        public static Vector128<float> _mm_add_ss/*Sse.AddScalar*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.AddScalar(left, right);

        public static Vector128<float> _mm_and_ps/*Sse.And*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.And(left, right);

        public static Vector128<float> _mm_andnot_ps/*Sse.AndNot*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.AndNot(left, right);

        public static Vector128<float> _mm_cmpeq_ps/*Sse.CompareEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareEqual(left, right);

        public static bool _mm_comieq_ss/*Sse.CompareScalarOrderedEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedEqual(left, right);

        public static bool _mm_ucomieq_ss/*Sse.CompareScalarUnorderedEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedEqual(left, right);

        public static Vector128<float> _mm_cmpeq_ss/*Sse.CompareScalarEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarEqual(left, right);

        public static Vector128<float> _mm_cmpgt_ps/*Sse.CompareGreaterThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareGreaterThan(left, right);

        public static bool _mm_comigt_ss/*Sse.CompareScalarOrderedGreaterThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedGreaterThan(left, right);

        public static bool _mm_ucomigt_ss/*Sse.CompareScalarUnorderedGreaterThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedGreaterThan(left, right);

        public static Vector128<float> _mm_cmpgt_ss/*Sse.CompareScalarGreaterThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarGreaterThan(left, right);

        public static Vector128<float> _mm_cmpge_ps/*Sse.CompareGreaterThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareGreaterThanOrEqual(left, right);

        public static bool _mm_comige_ss/*Sse.CompareScalarOrderedGreaterThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedGreaterThanOrEqual(left, right);

        public static bool _mm_ucomige_ss/*Sse.CompareScalarUnorderedGreaterThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpge_ss/*Sse.CompareScalarGreaterThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmplt_ps/*Sse.CompareLessThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareLessThan(left, right);

        public static bool _mm_comilt_ss/*Sse.CompareScalarOrderedLessThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedLessThan(left, right);

        public static bool _mm_ucomilt_ss/*Sse.CompareScalarUnorderedLessThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedLessThan(left, right);

        public static Vector128<float> _mm_cmplt_ss/*Sse.CompareScalarLessThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarLessThan(left, right);

        public static Vector128<float> _mm_cmple_ps/*Sse.CompareLessThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareLessThanOrEqual(left, right);

        public static bool _mm_comile_ss/*Sse.CompareScalarOrderedLessThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedLessThanOrEqual(left, right);

        public static bool _mm_ucomile_ss/*Sse.CompareScalarUnorderedLessThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmple_ss/*Sse.CompareScalarLessThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpneq_ps/*Sse.CompareNotEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotEqual(left, right);

        public static bool _mm_comineq_ss/*Sse.CompareScalarOrderedNotEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedNotEqual(left, right);

        public static bool _mm_ucomineq_ss/*Sse.CompareScalarUnorderedNotEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedNotEqual(left, right);

        public static Vector128<float> _mm_cmpneq_ss/*Sse.CompareScalarNotEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotEqual(left, right);

        public static Vector128<float> _mm_cmpngt_ps/*Sse.CompareNotGreaterThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotGreaterThan(left, right);

        public static Vector128<float> _mm_cmpngt_ss/*Sse.CompareScalarNotGreaterThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotGreaterThan(left, right);

        public static Vector128<float> _mm_cmpnge_ps/*Sse.CompareNotGreaterThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpnge_ss/*Sse.CompareScalarNotGreaterThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpnlt_ps/*Sse.CompareNotLessThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotLessThan(left, right);

        public static Vector128<float> _mm_cmpnlt_ss/*Sse.CompareScalarNotLessThan*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotLessThan(left, right);

        public static Vector128<float> _mm_cmpnle_ps/*Sse.CompareNotLessThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpnle_ss/*Sse.CompareScalarNotLessThanOrEqual*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpord_ps/*Sse.CompareOrdered*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareOrdered(left, right);

        public static Vector128<float> _mm_cmpord_ss/*Sse.CompareScalarOrdered*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrdered(left, right);

        public static Vector128<float> _mm_cmpunord_ps/*Sse.CompareUnordered*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareUnordered(left, right);

        public static Vector128<float> _mm_cmpunord_ss/*Sse.CompareScalarUnordered*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnordered(left, right);

        public static int _mm_cvtss_si32/*Sse.ConvertToInt32*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ConvertToInt32(value);

        public static Vector128<float> _mm_cvtsi32_ss/*Sse.ConvertScalarToVector128Single*/(Vector128<float> upper, int value) => System.Runtime.Intrinsics.X86.Sse.ConvertScalarToVector128Single(upper, value);

        public static int _mm_cvttss_si32/*Sse.ConvertToInt32WithTruncation*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ConvertToInt32WithTruncation(value);

        public static Vector128<float> _mm_div_ps/*Sse.Divide*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Divide(left, right);

        public static Vector128<float> _mm_div_ss/*Sse.DivideScalar*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.DivideScalar(left, right);

        public static unsafe Vector128<float> _mm_loadu_ps/*Sse.LoadVector128*/(float* address) => System.Runtime.Intrinsics.X86.Sse.LoadVector128(address);

        public static unsafe Vector128<float> _mm_load_ss/*Sse.LoadScalarVector128*/(float* address) => System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(address);

        public static unsafe Vector128<float> _mm_load_ps/*Sse.LoadAlignedVector128*/(float* address) => System.Runtime.Intrinsics.X86.Sse.LoadAlignedVector128(address);

        public static unsafe Vector128<float> _mm_loadh_pi/*Sse.LoadHigh*/(Vector128<float> lower, float* address) => System.Runtime.Intrinsics.X86.Sse.LoadHigh(lower, address);

        public static unsafe Vector128<float> _mm_loadl_pi/*Sse.LoadLow*/(Vector128<float> upper, float* address) => System.Runtime.Intrinsics.X86.Sse.LoadLow(upper, address);

        public static Vector128<float> _mm_max_ps/*Sse.Max*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Max(left, right);

        public static Vector128<float> _mm_max_ss/*Sse.MaxScalar*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MaxScalar(left, right);

        public static Vector128<float> _mm_min_ps/*Sse.Min*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Min(left, right);

        public static Vector128<float> _mm_min_ss/*Sse.MinScalar*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MinScalar(left, right);

        public static Vector128<float> _mm_move_ss/*Sse.MoveScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.MoveScalar(upper, value);

        public static Vector128<float> _mm_movehl_ps/*Sse.MoveHighToLow*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MoveHighToLow(left, right);

        public static Vector128<float> _mm_movelh_ps/*Sse.MoveLowToHigh*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MoveLowToHigh(left, right);

        public static int _mm_movemask_ps/*Sse.MoveMask*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.MoveMask(value);

        public static Vector128<float> _mm_mul_ps/*Sse.Multiply*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Multiply(left, right);

        public static Vector128<float> _mm_mul_ss/*Sse.MultiplyScalar*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(left, right);

        public static Vector128<float> _mm_or_ps/*Sse.Or*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Or(left, right);

        public static unsafe void _mm_prefetch0/*Sse.Prefetch0*/(void* address) => System.Runtime.Intrinsics.X86.Sse.Prefetch0(address);

        public static unsafe void _mm_prefetch1/*Sse.Prefetch1*/(void* address) => System.Runtime.Intrinsics.X86.Sse.Prefetch1(address);

        public static unsafe void _mm_prefetch2/*Sse.Prefetch2*/(void* address) => System.Runtime.Intrinsics.X86.Sse.Prefetch2(address);

        public static unsafe void _mm_prefetchl/*Sse.PrefetchNonTemporal*/(void* address) => System.Runtime.Intrinsics.X86.Sse.PrefetchNonTemporal(address);

        public static Vector128<float> _mm_rcp_ps/*Sse.Reciprocal*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.Reciprocal(value);

        public static Vector128<float> _mm_rcp_ss/*Sse.ReciprocalScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalScalar(value);

        public static Vector128<float> _mm_rcp_ss/*Sse.ReciprocalScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalScalar(upper, value);

        public static Vector128<float> _mm_rsqrt_ps/*Sse.ReciprocalSqrt*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrt(value);

        public static Vector128<float> _mm_rsqrt_ss/*Sse.ReciprocalSqrtScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrtScalar(value);

        public static Vector128<float> _mm_rsqrt_ss/*Sse.ReciprocalSqrtScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrtScalar(upper, value);

        public static Vector128<float> _mm_shuffle_ps/*Sse.Shuffle*/(Vector128<float> left, Vector128<float> right, byte control) => System.Runtime.Intrinsics.X86.Sse.Shuffle(left, right, control);

        public static Vector128<float> _mm_sqrt_ps/*Sse.Sqrt*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.Sqrt(value);

        public static Vector128<float> _mm_sqrt_ss/*Sse.SqrtScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.SqrtScalar(value);

        public static Vector128<float> _mm_sqrt_ss/*Sse.SqrtScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.SqrtScalar(upper, value);

        public static unsafe void _mm_store_ps/*Sse.StoreAligned*/(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreAligned(address, source);

        public static unsafe void _mm_stream_ps/*Sse.StoreAlignedNonTemporal*/(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_storeu_ps/*Sse.Store*/(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.Store(address, source);

        public static void _mm_sfence/*Sse.StoreFence*/() => System.Runtime.Intrinsics.X86.Sse.StoreFence();

        public static unsafe void _mm_store_ss/*Sse.StoreScalar*/(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreScalar(address, source);

        public static unsafe void _mm_storeh_pi/*Sse.StoreHigh*/(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreHigh(address, source);

        public static unsafe void _mm_storel_pi/*Sse.StoreLow*/(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreLow(address, source);

        public static Vector128<float> _mm_sub_ps/*Sse.Subtract*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Subtract(left, right);

        public static Vector128<float> _mm_sub_ss/*Sse.SubtractScalar*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.SubtractScalar(left, right);

        public static Vector128<float> _mm_unpackhi_ps/*Sse.UnpackHigh*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.UnpackHigh(left, right);

        public static Vector128<float> _mm_unpacklo_ps/*Sse.UnpackLow*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.UnpackLow(left, right);

        public static Vector128<float> _mm_xor_ps/*Sse.Xor*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Xor(left, right);

        public static long _mm_cvtss_si64/*Sse.X64.ConvertToInt64*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertToInt64(value);

        public static Vector128<float> _mm_cvtsi64_ss/*Sse.X64.ConvertScalarToVector128Single*/(Vector128<float> upper, long value) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertScalarToVector128Single(upper, value);

        public static long _mm_cvttss_si64/*Sse.X64.ConvertToInt64WithTruncation*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertToInt64WithTruncation(value);

        public static Vector128<byte> _mm_add_epi8/*Sse2.Add*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<sbyte> _mm_add_epi8/*Sse2.Add*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<short> _mm_add_epi16/*Sse2.Add*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<ushort> _mm_add_epi16/*Sse2.Add*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<int> _mm_add_epi32/*Sse2.Add*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<uint> _mm_add_epi32/*Sse2.Add*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<long> _mm_add_epi64/*Sse2.Add*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<ulong> _mm_add_epi64/*Sse2.Add*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<double> _mm_add_pd/*Sse2.Add*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<double> _mm_add_sd/*Sse2.AddScalar*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.AddScalar(left, right);

        public static Vector128<sbyte> _mm_adds_epi8/*Sse2.AddSaturate*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<byte> _mm_adds_epu8/*Sse2.AddSaturate*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<short> _mm_adds_epi16/*Sse2.AddSaturate*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<ushort> _mm_adds_epu16/*Sse2.AddSaturate*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<byte> _mm_and_si128/*Sse2.And*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<sbyte> _mm_and_si128/*Sse2.And*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<short> _mm_and_si128/*Sse2.And*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<ushort> _mm_and_si128/*Sse2.And*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<int> _mm_and_si128/*Sse2.And*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<uint> _mm_and_si128/*Sse2.And*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<long> _mm_and_si128/*Sse2.And*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<ulong> _mm_and_si128/*Sse2.And*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<double> _mm_and_pd/*Sse2.And*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<byte> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<sbyte> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<short> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<ushort> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<int> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<uint> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<long> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<ulong> _mm_andnot_si128/*Sse2.AndNot*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<double> _mm_andnot_pd/*Sse2.AndNot*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<byte> _mm_avg_epu8/*Sse2.Average*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Average(left, right);

        public static Vector128<ushort> _mm_avg_epu16/*Sse2.Average*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Average(left, right);

        public static Vector128<sbyte> _mm_cmpeq_epi8/*Sse2.CompareEqual*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<byte> _mm_cmpeq_epi8/*Sse2.CompareEqual*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<short> _mm_cmpeq_epi16/*Sse2.CompareEqual*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<ushort> _mm_cmpeq_epi16/*Sse2.CompareEqual*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<int> _mm_cmpeq_epi32/*Sse2.CompareEqual*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<uint> _mm_cmpeq_epi32/*Sse2.CompareEqual*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<double> _mm_cmpeq_pd/*Sse2.CompareEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static bool _mm_comieq_sd/*Sse2.CompareScalarOrderedEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedEqual(left, right);

        public static bool _mm_ucomieq_sd/*Sse2.CompareScalarUnorderedEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedEqual(left, right);

        public static Vector128<double> _mm_cmpeq_sd/*Sse2.CompareScalarEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarEqual(left, right);

        public static Vector128<sbyte> _mm_cmpgt_epi8/*Sse2.CompareGreaterThan*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static Vector128<short> _mm_cmpgt_epi16/*Sse2.CompareGreaterThan*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static Vector128<int> _mm_cmpgt_epi32/*Sse2.CompareGreaterThan*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static Vector128<double> _mm_cmpgt_pd/*Sse2.CompareGreaterThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static bool _mm_comigt_sd/*Sse2.CompareScalarOrderedGreaterThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedGreaterThan(left, right);

        public static bool _mm_ucomigt_sd/*Sse2.CompareScalarUnorderedGreaterThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedGreaterThan(left, right);

        public static Vector128<double> _mm_cmpgt_sd/*Sse2.CompareScalarGreaterThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarGreaterThan(left, right);

        public static Vector128<double> _mm_cmpge_pd/*Sse2.CompareGreaterThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThanOrEqual(left, right);

        public static bool _mm_comige_sd/*Sse2.CompareScalarOrderedGreaterThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedGreaterThanOrEqual(left, right);

        public static bool _mm_ucomige_sd/*Sse2.CompareScalarUnorderedGreaterThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedGreaterThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpge_sd/*Sse2.CompareScalarGreaterThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarGreaterThanOrEqual(left, right);

        public static Vector128<sbyte> _mm_cmplt_epi8/*Sse2.CompareLessThan*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static Vector128<short> _mm_cmplt_epi16/*Sse2.CompareLessThan*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static Vector128<int> _mm_cmplt_epi32/*Sse2.CompareLessThan*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static Vector128<double> _mm_cmplt_pd/*Sse2.CompareLessThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static bool _mm_comilt_sd/*Sse2.CompareScalarOrderedLessThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedLessThan(left, right);

        public static bool _mm_ucomilt_sd/*Sse2.CompareScalarUnorderedLessThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedLessThan(left, right);

        public static Vector128<double> _mm_cmplt_sd/*Sse2.CompareScalarLessThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarLessThan(left, right);

        public static Vector128<double> _mm_cmple_pd/*Sse2.CompareLessThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThanOrEqual(left, right);

        public static bool _mm_comile_sd/*Sse2.CompareScalarOrderedLessThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedLessThanOrEqual(left, right);

        public static bool _mm_ucomile_sd/*Sse2.CompareScalarUnorderedLessThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmple_sd/*Sse2.CompareScalarLessThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpneq_pd/*Sse2.CompareNotEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotEqual(left, right);

        public static bool _mm_comineq_sd/*Sse2.CompareScalarOrderedNotEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedNotEqual(left, right);

        public static bool _mm_ucomineq_sd/*Sse2.CompareScalarUnorderedNotEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedNotEqual(left, right);

        public static Vector128<double> _mm_cmpneq_sd/*Sse2.CompareScalarNotEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotEqual(left, right);

        public static Vector128<double> _mm_cmpngt_pd/*Sse2.CompareNotGreaterThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotGreaterThan(left, right);

        public static Vector128<double> _mm_cmpngt_sd/*Sse2.CompareScalarNotGreaterThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotGreaterThan(left, right);

        public static Vector128<double> _mm_cmpnge_pd/*Sse2.CompareNotGreaterThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotGreaterThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpnge_sd/*Sse2.CompareScalarNotGreaterThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotGreaterThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpnlt_pd/*Sse2.CompareNotLessThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotLessThan(left, right);

        public static Vector128<double> _mm_cmpnlt_sd/*Sse2.CompareScalarNotLessThan*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotLessThan(left, right);

        public static Vector128<double> _mm_cmpnle_pd/*Sse2.CompareNotLessThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpnle_sd/*Sse2.CompareScalarNotLessThanOrEqual*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpord_pd/*Sse2.CompareOrdered*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareOrdered(left, right);

        public static Vector128<double> _mm_cmpord_sd/*Sse2.CompareScalarOrdered*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrdered(left, right);

        public static Vector128<double> _mm_cmpunord_pd/*Sse2.CompareUnordered*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareUnordered(left, right);

        public static Vector128<double> _mm_cmpunord_sd/*Sse2.CompareScalarUnordered*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnordered(left, right);

        public static Vector128<int> _mm_cvtps_epi32/*Sse2.ConvertToVector128Int32*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtpd_epi32/*Sse2.ConvertToVector128Int32*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32(value);

        public static Vector128<float> _mm_cvtepi32_ps/*Sse2.ConvertToVector128Single*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Single(value);

        public static Vector128<float> _mm_cvtpd_ps/*Sse2.ConvertToVector128Single*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Single(value);

        public static Vector128<double> _mm_cvtepi32_pd/*Sse2.ConvertToVector128Double*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Double(value);

        public static Vector128<double> _mm_cvtps_pd/*Sse2.ConvertToVector128Double*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Double(value);

        public static int _mm_cvtsd_si32/*Sse2.ConvertToInt32*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32(value);

        public static int _mm_cvtsi128_si32/*Sse2.ConvertToInt32*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32(value);

        public static uint _mm_cvtsi128_si32/*Sse2.ConvertToUInt32*/(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToUInt32(value);

        public static Vector128<double> _mm_cvtsi32_sd/*Sse2.ConvertScalarToVector128Double*/(Vector128<double> upper, int value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Double(upper, value);

        public static Vector128<double> _mm_cvtss_sd/*Sse2.ConvertScalarToVector128Double*/(Vector128<double> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Double(upper, value);

        public static Vector128<int> _mm_cvtsi32_si128/*Sse2.ConvertScalarToVector128Int32*/(int value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Int32(value);

        public static Vector128<float> _mm_cvtsd_ss/*Sse2.ConvertScalarToVector128Single*/(Vector128<float> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Single(upper, value);

        public static Vector128<uint> _mm_cvtsi32_si128/*Sse2.ConvertScalarToVector128UInt32*/(uint value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128UInt32(value);

        public static Vector128<int> _mm_cvttps_epi32/*Sse2.ConvertToVector128Int32WithTruncation*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32WithTruncation(value);

        public static Vector128<int> _mm_cvttpd_epi32/*Sse2.ConvertToVector128Int32WithTruncation*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32WithTruncation(value);

        public static int _mm_cvttsd_si32/*Sse2.ConvertToInt32WithTruncation*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32WithTruncation(value);

        public static Vector128<double> _mm_div_pd/*Sse2.Divide*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Divide(left, right);

        public static Vector128<double> _mm_div_sd/*Sse2.DivideScalar*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.DivideScalar(left, right);

        public static ushort _mm_extract_epi16/*Sse2.Extract*/(Vector128<ushort> value, byte index) => System.Runtime.Intrinsics.X86.Sse2.Extract(value, index);

        public static Vector128<short> _mm_insert_epi16/*Sse2.Insert*/(Vector128<short> value, short data, byte index) => System.Runtime.Intrinsics.X86.Sse2.Insert(value, data, index);

        public static Vector128<ushort> _mm_insert_epi16/*Sse2.Insert*/(Vector128<ushort> value, ushort data, byte index) => System.Runtime.Intrinsics.X86.Sse2.Insert(value, data, index);

        public static unsafe Vector128<sbyte> _mm_loadu_si128/*Sse2.LoadVector128*/(sbyte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<byte> _mm_loadu_si128/*Sse2.LoadVector128*/(byte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<short> _mm_loadu_si128/*Sse2.LoadVector128*/(short* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<ushort> _mm_loadu_si128/*Sse2.LoadVector128*/(ushort* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<int> _mm_loadu_si128/*Sse2.LoadVector128*/(int* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<uint> _mm_loadu_si128/*Sse2.LoadVector128*/(uint* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<long> _mm_loadu_si128/*Sse2.LoadVector128*/(long* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<ulong> _mm_loadu_si128/*Sse2.LoadVector128*/(ulong* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<double> _mm_loadu_pd/*Sse2.LoadVector128*/(double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<double> _mm_load_sd/*Sse2.LoadScalarVector128*/(double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<sbyte> _mm_load_si128/*Sse2.LoadAlignedVector128*/(sbyte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<byte> _mm_load_si128/*Sse2.LoadAlignedVector128*/(byte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<short> _mm_load_si128/*Sse2.LoadAlignedVector128*/(short* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<ushort> _mm_load_si128/*Sse2.LoadAlignedVector128*/(ushort* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<int> _mm_load_si128/*Sse2.LoadAlignedVector128*/(int* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<uint> _mm_load_si128/*Sse2.LoadAlignedVector128*/(uint* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<long> _mm_load_si128/*Sse2.LoadAlignedVector128*/(long* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<ulong> _mm_load_si128/*Sse2.LoadAlignedVector128*/(ulong* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<double> _mm_load_pd/*Sse2.LoadAlignedVector128*/(double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static void _mm_lfence/*Sse2.LoadFence*/() => System.Runtime.Intrinsics.X86.Sse2.LoadFence();

        public static unsafe Vector128<double> _mm_loadh_pd/*Sse2.LoadHigh*/(Vector128<double> lower, double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadHigh(lower, address);

        public static unsafe Vector128<double> _mm_loadl_pd/*Sse2.LoadLow*/(Vector128<double> upper, double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadLow(upper, address);

        public static unsafe Vector128<int> _mm_loadl_epi32/*Sse2.LoadScalarVector128*/(int* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<uint> _mm_loadl_epi32/*Sse2.LoadScalarVector128*/(uint* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<long> _mm_loadl_epi64/*Sse2.LoadScalarVector128*/(long* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<ulong> _mm_loadl_epi64/*Sse2.LoadScalarVector128*/(ulong* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe void _mm_maskmoveu_si128/*Sse2.MaskMove*/(Vector128<sbyte> source, Vector128<sbyte> mask, sbyte* address) => System.Runtime.Intrinsics.X86.Sse2.MaskMove(source, mask, address);

        public static unsafe void _mm_maskmoveu_si128/*Sse2.MaskMove*/(Vector128<byte> source, Vector128<byte> mask, byte* address) => System.Runtime.Intrinsics.X86.Sse2.MaskMove(source, mask, address);

        public static Vector128<byte> _mm_max_epu8/*Sse2.Max*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Max(left, right);

        public static Vector128<short> _mm_max_epi16/*Sse2.Max*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Max(left, right);

        public static Vector128<double> _mm_max_pd/*Sse2.Max*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Max(left, right);

        public static Vector128<double> _mm_max_sd/*Sse2.MaxScalar*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.MaxScalar(left, right);

        public static void _mm_mfence/*Sse2.MemoryFence*/() => System.Runtime.Intrinsics.X86.Sse2.MemoryFence();

        public static Vector128<byte> _mm_min_epu8/*Sse2.Min*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Min(left, right);

        public static Vector128<short> _mm_min_epi16/*Sse2.Min*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Min(left, right);

        public static Vector128<double> _mm_min_pd/*Sse2.Min*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Min(left, right);

        public static Vector128<double> _mm_min_sd/*Sse2.MinScalar*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.MinScalar(left, right);

        public static Vector128<double> _mm_move_sd/*Sse2.MoveScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(upper, value);

        public static int _mm_movemask_epi8/*Sse2.MoveMask*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(value);

        public static int _mm_movemask_epi8/*Sse2.MoveMask*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(value);

        public static int _mm_movemask_pd/*Sse2.MoveMask*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(value);

        public static Vector128<long> _mm_move_epi64/*Sse2.MoveScalar*/(Vector128<long> value) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(value);

        public static Vector128<ulong> _mm_move_epi64/*Sse2.MoveScalar*/(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(value);

        public static Vector128<ulong> _mm_mul_epu32/*Sse2.Multiply*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Multiply(left, right);

        public static Vector128<double> _mm_mul_pd/*Sse2.Multiply*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Multiply(left, right);

        public static Vector128<double> _mm_mul_sd/*Sse2.MultiplyScalar*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyScalar(left, right);

        public static Vector128<short> _mm_mulhi_epi16/*Sse2.MultiplyHigh*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyHigh(left, right);

        public static Vector128<ushort> _mm_mulhi_epu16/*Sse2.MultiplyHigh*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyHigh(left, right);

        public static Vector128<int> _mm_madd_epi16/*Sse2.MultiplyAddAdjacent*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyAddAdjacent(left, right);

        public static Vector128<short> _mm_mullo_epi16/*Sse2.MultiplyLow*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyLow(left, right);

        public static Vector128<ushort> _mm_mullo_epi16/*Sse2.MultiplyLow*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyLow(left, right);

        public static Vector128<byte> _mm_or_si128/*Sse2.Or*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<sbyte> _mm_or_si128/*Sse2.Or*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<short> _mm_or_si128/*Sse2.Or*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<ushort> _mm_or_si128/*Sse2.Or*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<int> _mm_or_si128/*Sse2.Or*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<uint> _mm_or_si128/*Sse2.Or*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<long> _mm_or_si128/*Sse2.Or*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<ulong> _mm_or_si128/*Sse2.Or*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<double> _mm_or_pd/*Sse2.Or*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<sbyte> _mm_packs_epi16/*Sse2.PackSignedSaturate*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.PackSignedSaturate(left, right);

        public static Vector128<short> _mm_packs_epi32/*Sse2.PackSignedSaturate*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.PackSignedSaturate(left, right);

        public static Vector128<byte> _mm_packus_epi16/*Sse2.PackUnsignedSaturate*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.PackUnsignedSaturate(left, right);

        public static Vector128<ushort> _mm_sad_epu8/*Sse2.SumAbsoluteDifferences*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.SumAbsoluteDifferences(left, right);

        public static Vector128<int> _mm_shuffle_epi32/*Sse2.Shuffle*/(Vector128<int> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(value, control);

        public static Vector128<uint> _mm_shuffle_epi32/*Sse2.Shuffle*/(Vector128<uint> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(value, control);

        public static Vector128<double> _mm_shuffle_pd/*Sse2.Shuffle*/(Vector128<double> left, Vector128<double> right, byte control) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(left, right, control);

        public static Vector128<short> _mm_shufflehi_epi16/*Sse2.ShuffleHigh*/(Vector128<short> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleHigh(value, control);

        public static Vector128<ushort> _mm_shufflehi_epi16/*Sse2.ShuffleHigh*/(Vector128<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleHigh(value, control);

        public static Vector128<short> _mm_shufflelo_epi16/*Sse2.ShuffleLow*/(Vector128<short> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleLow(value, control);

        public static Vector128<ushort> _mm_shufflelo_epi16/*Sse2.ShuffleLow*/(Vector128<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleLow(value, control);

        public static Vector128<short> _mm_sll_epi16/*Sse2.ShiftLeftLogical*/(Vector128<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ushort> _mm_sll_epi16/*Sse2.ShiftLeftLogical*/(Vector128<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<int> _mm_sll_epi32/*Sse2.ShiftLeftLogical*/(Vector128<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<uint> _mm_sll_epi32/*Sse2.ShiftLeftLogical*/(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<long> _mm_sll_epi64/*Sse2.ShiftLeftLogical*/(Vector128<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ulong> _mm_sll_epi64/*Sse2.ShiftLeftLogical*/(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<short> _mm_slli_epi16/*Sse2.ShiftLeftLogical*/(Vector128<short> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ushort> _mm_slli_epi16/*Sse2.ShiftLeftLogical*/(Vector128<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<int> _mm_slli_epi32/*Sse2.ShiftLeftLogical*/(Vector128<int> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<uint> _mm_slli_epi32/*Sse2.ShiftLeftLogical*/(Vector128<uint> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<long> _mm_slli_epi64/*Sse2.ShiftLeftLogical*/(Vector128<long> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ulong> _mm_slli_epi64/*Sse2.ShiftLeftLogical*/(Vector128<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<sbyte> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<byte> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<short> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<ushort> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<int> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<uint> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<long> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<ulong> _mm_bslli_si128/*Sse2.ShiftLeftLogical128BitLane*/(Vector128<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<short> _mm_sra_epi16/*Sse2.ShiftRightArithmetic*/(Vector128<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<int> _mm_sra_epi32/*Sse2.ShiftRightArithmetic*/(Vector128<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<short> _mm_srai_epi16/*Sse2.ShiftRightArithmetic*/(Vector128<short> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<int> _mm_srai_epi32/*Sse2.ShiftRightArithmetic*/(Vector128<int> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<short> _mm_srl_epi16/*Sse2.ShiftRightLogical*/(Vector128<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ushort> _mm_srl_epi16/*Sse2.ShiftRightLogical*/(Vector128<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<int> _mm_srl_epi32/*Sse2.ShiftRightLogical*/(Vector128<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<uint> _mm_srl_epi32/*Sse2.ShiftRightLogical*/(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<long> _mm_srl_epi64/*Sse2.ShiftRightLogical*/(Vector128<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ulong> _mm_srl_epi64/*Sse2.ShiftRightLogical*/(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<short> _mm_srli_epi16/*Sse2.ShiftRightLogical*/(Vector128<short> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ushort> _mm_srli_epi16/*Sse2.ShiftRightLogical*/(Vector128<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<int> _mm_srli_epi32/*Sse2.ShiftRightLogical*/(Vector128<int> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<uint> _mm_srli_epi32/*Sse2.ShiftRightLogical*/(Vector128<uint> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<long> _mm_srli_epi64/*Sse2.ShiftRightLogical*/(Vector128<long> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ulong> _mm_srli_epi64/*Sse2.ShiftRightLogical*/(Vector128<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<sbyte> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<byte> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<short> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<ushort> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<int> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<uint> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<long> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<ulong> _mm_bsrli_si128/*Sse2.ShiftRightLogical128BitLane*/(Vector128<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<double> _mm_sqrt_pd/*Sse2.Sqrt*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.Sqrt(value);

        public static Vector128<double> _mm_sqrt_sd/*Sse2.SqrtScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.SqrtScalar(value);

        public static Vector128<double> _mm_sqrt_sd/*Sse2.SqrtScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.SqrtScalar(upper, value);

        public static unsafe void _mm_store_sd/*Sse2.StoreScalar*/(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar(address, source);

        public static unsafe void _mm_storel_epi64/*Sse2.StoreScalar*/(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar(address, source);

        public static unsafe void _mm_storel_epi64/*Sse2.StoreScalar*/(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(sbyte* address, Vector128<sbyte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(byte* address, Vector128<byte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(short* address, Vector128<short> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(ushort* address, Vector128<ushort> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(int* address, Vector128<int> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(uint* address, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128/*Sse2.StoreAligned*/(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_pd/*Sse2.StoreAligned*/(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(sbyte* address, Vector128<sbyte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(byte* address, Vector128<byte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(short* address, Vector128<short> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(ushort* address, Vector128<ushort> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(int* address, Vector128<int> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(uint* address, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128/*Sse2.StoreAlignedNonTemporal*/(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_pd/*Sse2.StoreAlignedNonTemporal*/(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(sbyte* address, Vector128<sbyte> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(byte* address, Vector128<byte> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(short* address, Vector128<short> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(ushort* address, Vector128<ushort> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(int* address, Vector128<int> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(uint* address, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128/*Sse2.Store*/(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_pd/*Sse2.Store*/(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeh_pd/*Sse2.StoreHigh*/(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreHigh(address, source);

        public static unsafe void _mm_storel_pd/*Sse2.StoreLow*/(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreLow(address, source);

        public static unsafe void _mm_stream_si32/*Sse2.StoreNonTemporal*/(int* address, int value) => System.Runtime.Intrinsics.X86.Sse2.StoreNonTemporal(address, value);

        public static unsafe void _mm_stream_si32/*Sse2.StoreNonTemporal*/(uint* address, uint value) => System.Runtime.Intrinsics.X86.Sse2.StoreNonTemporal(address, value);

        public static Vector128<byte> _mm_sub_epi8/*Sse2.Subtract*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<sbyte> _mm_sub_epi8/*Sse2.Subtract*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<short> _mm_sub_epi16/*Sse2.Subtract*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<ushort> _mm_sub_epi16/*Sse2.Subtract*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<int> _mm_sub_epi32/*Sse2.Subtract*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<uint> _mm_sub_epi32/*Sse2.Subtract*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<long> _mm_sub_epi64/*Sse2.Subtract*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<ulong> _mm_sub_epi64/*Sse2.Subtract*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<double> _mm_sub_pd/*Sse2.Subtract*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<double> _mm_sub_sd/*Sse2.SubtractScalar*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractScalar(left, right);

        public static Vector128<sbyte> _mm_subs_epi8/*Sse2.SubtractSaturate*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<short> _mm_subs_epi16/*Sse2.SubtractSaturate*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<byte> _mm_subs_epu8/*Sse2.SubtractSaturate*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<ushort> _mm_subs_epu16/*Sse2.SubtractSaturate*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<byte> _mm_unpackhi_epi8/*Sse2.UnpackHigh*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<sbyte> _mm_unpackhi_epi8/*Sse2.UnpackHigh*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<short> _mm_unpackhi_epi16/*Sse2.UnpackHigh*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<ushort> _mm_unpackhi_epi16/*Sse2.UnpackHigh*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<int> _mm_unpackhi_epi32/*Sse2.UnpackHigh*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<uint> _mm_unpackhi_epi32/*Sse2.UnpackHigh*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<long> _mm_unpackhi_epi64/*Sse2.UnpackHigh*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<ulong> _mm_unpackhi_epi64/*Sse2.UnpackHigh*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<double> _mm_unpackhi_pd/*Sse2.UnpackHigh*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<byte> _mm_unpacklo_epi8/*Sse2.UnpackLow*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<sbyte> _mm_unpacklo_epi8/*Sse2.UnpackLow*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<short> _mm_unpacklo_epi16/*Sse2.UnpackLow*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<ushort> _mm_unpacklo_epi16/*Sse2.UnpackLow*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<int> _mm_unpacklo_epi32/*Sse2.UnpackLow*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<uint> _mm_unpacklo_epi32/*Sse2.UnpackLow*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<long> _mm_unpacklo_epi64/*Sse2.UnpackLow*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<ulong> _mm_unpacklo_epi64/*Sse2.UnpackLow*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<double> _mm_unpacklo_pd/*Sse2.UnpackLow*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<byte> _mm_xor_si128/*Sse2.Xor*/(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<sbyte> _mm_xor_si128/*Sse2.Xor*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<short> _mm_xor_si128/*Sse2.Xor*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<ushort> _mm_xor_si128/*Sse2.Xor*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<int> _mm_xor_si128/*Sse2.Xor*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<uint> _mm_xor_si128/*Sse2.Xor*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<long> _mm_xor_si128/*Sse2.Xor*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<ulong> _mm_xor_si128/*Sse2.Xor*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<double> _mm_xor_pd/*Sse2.Xor*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static long _mm_cvtsd_si64/*Sse2.X64.ConvertToInt64*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64(value);

        public static long _mm_cvtsi128_si64/*Sse2.X64.ConvertToInt64*/(Vector128<long> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64(value);

        public static ulong _mm_cvtsi128_si64/*Sse2.X64.ConvertToUInt64*/(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToUInt64(value);

        public static Vector128<double> _mm_cvtsi64_sd/*Sse2.X64.ConvertScalarToVector128Double*/(Vector128<double> upper, long value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128Double(upper, value);

        public static Vector128<long> _mm_cvtsi64_si128/*Sse2.X64.ConvertScalarToVector128Int64*/(long value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128Int64(value);

        public static Vector128<ulong> _mm_cvtsi64_si128/*Sse2.X64.ConvertScalarToVector128UInt64*/(ulong value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128UInt64(value);

        public static long _mm_cvttsd_si64/*Sse2.X64.ConvertToInt64WithTruncation*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64WithTruncation(value);

        public static unsafe void _mm_stream_si64/*Sse2.X64.StoreNonTemporal*/(long* address, long value) => System.Runtime.Intrinsics.X86.Sse2.X64.StoreNonTemporal(address, value);

        public static unsafe void _mm_stream_si64/*Sse2.X64.StoreNonTemporal*/(ulong* address, ulong value) => System.Runtime.Intrinsics.X86.Sse2.X64.StoreNonTemporal(address, value);

        public static Vector128<float> _mm_addsub_ps/*Sse3.AddSubtract*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse3.AddSubtract(left, right);

        public static Vector128<double> _mm_addsub_pd/*Sse3.AddSubtract*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse3.AddSubtract(left, right);

        public static Vector128<float> _mm_hadd_ps/*Sse3.HorizontalAdd*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalAdd(left, right);

        public static Vector128<double> _mm_hadd_pd/*Sse3.HorizontalAdd*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalAdd(left, right);

        public static Vector128<float> _mm_hsub_ps/*Sse3.HorizontalSubtract*/(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalSubtract(left, right);

        public static Vector128<double> _mm_hsub_pd/*Sse3.HorizontalSubtract*/(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalSubtract(left, right);

        public static unsafe Vector128<double> _mm_loaddup_pd/*Sse3.LoadAndDuplicateToVector128*/(double* address) => System.Runtime.Intrinsics.X86.Sse3.LoadAndDuplicateToVector128(address);

        public static unsafe Vector128<sbyte> _mm_lddqu_si128/*Sse3.LoadDquVector128*/(sbyte* address) => System.Runtime.Intrinsics.X86.Sse3.LoadDquVector128(address);

        public static Vector128<double> _mm_movedup_pd/*Sse3.MoveAndDuplicate*/(Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse3.MoveAndDuplicate(source);

        public static Vector128<float> _mm_movehdup_ps/*Sse3.MoveHighAndDuplicate*/(Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse3.MoveHighAndDuplicate(source);

        public static Vector128<float> _mm_moveldup_ps/*Sse3.MoveLowAndDuplicate*/(Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse3.MoveLowAndDuplicate(source);

        public static Vector128<short> _mm_blend_epi16/*Sse41.Blend*/(Vector128<short> left, Vector128<short> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<ushort> _mm_blend_epi16/*Sse41.Blend*/(Vector128<ushort> left, Vector128<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<float> _mm_blend_ps/*Sse41.Blend*/(Vector128<float> left, Vector128<float> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<double> _mm_blend_pd/*Sse41.Blend*/(Vector128<double> left, Vector128<double> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<sbyte> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<byte> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<short> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<short> left, Vector128<short> right, Vector128<short> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<ushort> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<ushort> left, Vector128<ushort> right, Vector128<ushort> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<int> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<int> left, Vector128<int> right, Vector128<int> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<uint> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<uint> left, Vector128<uint> right, Vector128<uint> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<long> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<long> left, Vector128<long> right, Vector128<long> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<ulong> _mm_blendv_epi8/*Sse41.BlendVariable*/(Vector128<ulong> left, Vector128<ulong> right, Vector128<ulong> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<float> _mm_blendv_ps/*Sse41.BlendVariable*/(Vector128<float> left, Vector128<float> right, Vector128<float> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<double> _mm_blendv_pd/*Sse41.BlendVariable*/(Vector128<double> left, Vector128<double> right, Vector128<double> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<float> _mm_ceil_ps/*Sse41.Ceiling*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.Ceiling(value);

        public static Vector128<double> _mm_ceil_pd/*Sse41.Ceiling*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.Ceiling(value);

        public static Vector128<double> _mm_ceil_sd/*Sse41.CeilingScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(value);

        public static Vector128<float> _mm_ceil_ss/*Sse41.CeilingScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(value);

        public static Vector128<double> _mm_ceil_sd/*Sse41.CeilingScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(upper, value);

        public static Vector128<float> _mm_ceil_ss/*Sse41.CeilingScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(upper, value);

        public static Vector128<long> _mm_cmpeq_epi64/*Sse41.CompareEqual*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse41.CompareEqual(left, right);

        public static Vector128<ulong> _mm_cmpeq_epi64/*Sse41.CompareEqual*/(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse41.CompareEqual(left, right);

        public static Vector128<short> _mm_cvtepi8_epi16/*Sse41.ConvertToVector128Int16*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int16(value);

        public static Vector128<short> _mm_cvtepu8_epi16/*Sse41.ConvertToVector128Int16*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int16(value);

        public static Vector128<int> _mm_cvtepi8_epi32/*Sse41.ConvertToVector128Int32*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtepu8_epi32/*Sse41.ConvertToVector128Int32*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtepi16_epi32/*Sse41.ConvertToVector128Int32*/(Vector128<short> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtepu16_epi32/*Sse41.ConvertToVector128Int32*/(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<long> _mm_cvtepi8_epi64/*Sse41.ConvertToVector128Int64*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepu8_epi64/*Sse41.ConvertToVector128Int64*/(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepi16_epi64/*Sse41.ConvertToVector128Int64*/(Vector128<short> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepu16_epi64/*Sse41.ConvertToVector128Int64*/(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepi32_epi64/*Sse41.ConvertToVector128Int64*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepu32_epi64/*Sse41.ConvertToVector128Int64*/(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<float> _mm_dp_ps/*Sse41.DotProduct*/(Vector128<float> left, Vector128<float> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.DotProduct(left, right, control);

        public static Vector128<double> _mm_dp_pd/*Sse41.DotProduct*/(Vector128<double> left, Vector128<double> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.DotProduct(left, right, control);

        public static byte _mm_extract_epi8/*Sse41.Extract*/(Vector128<byte> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static int _mm_extract_epi32/*Sse41.Extract*/(Vector128<int> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static uint _mm_extract_epi32/*Sse41.Extract*/(Vector128<uint> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static float _mm_extract_ps/*Sse41.Extract*/(Vector128<float> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static Vector128<float> _mm_floor_ps/*Sse41.Floor*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.Floor(value);

        public static Vector128<double> _mm_floor_pd/*Sse41.Floor*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.Floor(value);

        public static Vector128<double> _mm_floor_sd/*Sse41.FloorScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(value);

        public static Vector128<float> _mm_floor_ss/*Sse41.FloorScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(value);

        public static Vector128<double> _mm_floor_sd/*Sse41.FloorScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(upper, value);

        public static Vector128<float> _mm_floor_ss/*Sse41.FloorScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(upper, value);

        public static Vector128<sbyte> _mm_insert_epi8/*Sse41.Insert*/(Vector128<sbyte> value, sbyte data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<byte> _mm_insert_epi8/*Sse41.Insert*/(Vector128<byte> value, byte data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<int> _mm_insert_epi32/*Sse41.Insert*/(Vector128<int> value, int data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<uint> _mm_insert_epi32/*Sse41.Insert*/(Vector128<uint> value, uint data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<float> _mm_insert_ps/*Sse41.Insert*/(Vector128<float> value, Vector128<float> data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<sbyte> _mm_max_epi8/*Sse41.Max*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<ushort> _mm_max_epu16/*Sse41.Max*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<int> _mm_max_epi32/*Sse41.Max*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<uint> _mm_max_epu32/*Sse41.Max*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<sbyte> _mm_min_epi8/*Sse41.Min*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<ushort> _mm_min_epu16/*Sse41.Min*/(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<int> _mm_min_epi32/*Sse41.Min*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<uint> _mm_min_epu32/*Sse41.Min*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<ushort> _mm_minpos_epu16/*Sse41.MinHorizontal*/(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Sse41.MinHorizontal(value);

        public static Vector128<ushort> _mm_mpsadbw_epu8/*Sse41.MultipleSumAbsoluteDifferences*/(Vector128<byte> left, Vector128<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Sse41.MultipleSumAbsoluteDifferences(left, right, mask);

        public static Vector128<long> _mm_mul_epi32/*Sse41.Multiply*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.Multiply(left, right);

        public static Vector128<int> _mm_mullo_epi32/*Sse41.MultiplyLow*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.MultiplyLow(left, right);

        public static Vector128<uint> _mm_mullo_epi32/*Sse41.MultiplyLow*/(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse41.MultiplyLow(left, right);

        public static Vector128<ushort> _mm_packus_epi32/*Sse41.PackUnsignedSaturate*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.PackUnsignedSaturate(left, right);

        public static Vector128<float> _mm_round_ps/*Sse41.RoundToNearestInteger*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestInteger(value);

        public static Vector128<float> _MM_FROUND_TO_NEG_INF/*Sse41.RoundToNegativeInfinity*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinity(value);

        public static Vector128<float> _MM_FROUND_TO_POS_INF/*Sse41.RoundToPositiveInfinity*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinity(value);

        public static Vector128<float> _MM_FROUND_TO_ZERO/*Sse41.RoundToZero*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZero(value);

        public static Vector128<float> _MM_FROUND_CUR_DIRECTION/*Sse41.RoundCurrentDirection*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirection(value);

        public static Vector128<double> _mm_round_pd/*Sse41.RoundToNearestInteger*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestInteger(value);

        public static Vector128<double> _MM_FROUND_TO_NEG_INF/*Sse41.RoundToNegativeInfinity*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinity(value);

        public static Vector128<double> _MM_FROUND_TO_POS_INF/*Sse41.RoundToPositiveInfinity*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinity(value);

        public static Vector128<double> _MM_FROUND_TO_ZERO/*Sse41.RoundToZero*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZero(value);

        public static Vector128<double> _MM_FROUND_CUR_DIRECTION/*Sse41.RoundCurrentDirection*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirection(value);

        public static Vector128<double> _mm_round_sd_RoundCurrentDirectionScalar/*Sse41.RoundCurrentDirectionScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(value);

        public static Vector128<double> _mm_round_sd_RoundToNearestIntegerScalar/*Sse41.RoundToNearestIntegerScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(value);

        public static Vector128<double> _mm_round_sd_RoundToNegativeInfinityScalar/*Sse41.RoundToNegativeInfinityScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(value);

        public static Vector128<double> _mm_round_sd_RoundToPositiveInfinityScalar/*Sse41.RoundToPositiveInfinityScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(value);

        public static Vector128<double> _mm_round_sd_RoundToZeroScalar/*Sse41.RoundToZeroScalar*/(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(value);

        public static Vector128<double> _mm_round_sd_RoundCurrentDirectionScalar/*Sse41.RoundCurrentDirectionScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(upper, value);

        public static Vector128<double> _mm_round_sd_RoundToNearestIntegerScalar/*Sse41.RoundToNearestIntegerScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(upper, value);

        public static Vector128<double> _mm_round_sd_RoundToNegativeInfinityScalar/*Sse41.RoundToNegativeInfinityScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(upper, value);

        public static Vector128<double> _mm_round_sd_RoundToPositiveInfinityScalar/*Sse41.RoundToPositiveInfinityScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(upper, value);

        public static Vector128<double> _mm_round_sd_RoundToZeroScalar/*Sse41.RoundToZeroScalar*/(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(upper, value);

        public static Vector128<float> _mm_round_ss_RoundCurrentDirectionScalar/*Sse41.RoundCurrentDirectionScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(value);

        public static Vector128<float> _mm_round_ss_RoundToNearestIntegerScalar/*Sse41.RoundToNearestIntegerScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(value);

        public static Vector128<float> _mm_round_ss_RoundToNegativeInfinityScalar/*Sse41.RoundToNegativeInfinityScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(value);

        public static Vector128<float> _mm_round_ss_RoundToPositiveInfinityScalar/*Sse41.RoundToPositiveInfinityScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(value);

        public static Vector128<float> _mm_round_ss_RoundToZeroScalar/*Sse41.RoundToZeroScalar*/(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(value);

        public static Vector128<float> _mm_round_ss_RoundCurrentDirectionScalar/*Sse41.RoundCurrentDirectionScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(upper, value);

        public static Vector128<float> _mm_round_ss_RoundToNearestIntegerScalar/*Sse41.RoundToNearestIntegerScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(upper, value);

        public static Vector128<float> _mm_round_ss_RoundToNegativeInfinityScalar/*Sse41.RoundToNegativeInfinityScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(upper, value);

        public static Vector128<float> _mm_round_ss_RoundToPositiveInfinityScalar/*Sse41.RoundToPositiveInfinityScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(upper, value);

        public static Vector128<float> _mm_round_ss_RoundToZeroScalar/*Sse41.RoundToZeroScalar*/(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(upper, value);

        public static unsafe Vector128<sbyte> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(sbyte* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<byte> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(byte* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<short> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(short* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<ushort> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(ushort* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<int> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(int* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<uint> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(uint* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<long> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(long* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<ulong> _mm_stream_load_si128/*Sse41.LoadAlignedVector128NonTemporal*/(ulong* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static bool _mm_testc_si128/*Sse41.TestC*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.TestC(left, right);

        public static bool _mm_testnzc_si128/*Sse41.TestNotZAndNotC*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.TestNotZAndNotC(left, right);

        public static bool _mm_testz_si128/*Sse41.TestZ*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.TestZ(left, right);

        public static long _mm_extract_epi64/*Sse41.X64.Extract*/(Vector128<long> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Extract(value, index);

        public static ulong _mm_extract_epi64/*Sse41.X64.Extract*/(Vector128<ulong> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Extract(value, index);

        public static Vector128<long> _mm_insert_epi64/*Sse41.X64.Insert*/(Vector128<long> value, long data, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Insert(value, data, index);

        public static Vector128<ulong> _mm_insert_epi64/*Sse41.X64.Insert*/(Vector128<ulong> value, ulong data, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Insert(value, data, index);

        public static Vector128<long> _mm_cmpgt_epi64/*Sse42.CompareGreaterThan*/(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse42.CompareGreaterThan(left, right);

        public static uint _mm_crc32_u8/*Sse42.Crc32*/(uint crc, byte data) => System.Runtime.Intrinsics.X86.Sse42.Crc32(crc, data);

        public static uint _mm_crc32_u16/*Sse42.Crc32*/(uint crc, ushort data) => System.Runtime.Intrinsics.X86.Sse42.Crc32(crc, data);

        public static uint _mm_crc32_u32/*Sse42.Crc32*/(uint crc, uint data) => System.Runtime.Intrinsics.X86.Sse42.Crc32(crc, data);

        public static ulong _mm_crc32_u64/*Sse42.X64.Crc32*/(ulong crc, ulong data) => System.Runtime.Intrinsics.X86.Sse42.X64.Crc32(crc, data);

        public static Vector128<byte> _mm_abs_epi8/*Ssse3.Abs*/(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Ssse3.Abs(value);

        public static Vector128<ushort> _mm_abs_epi16/*Ssse3.Abs*/(Vector128<short> value) => System.Runtime.Intrinsics.X86.Ssse3.Abs(value);

        public static Vector128<uint> _mm_abs_epi32/*Ssse3.Abs*/(Vector128<int> value) => System.Runtime.Intrinsics.X86.Ssse3.Abs(value);

        public static Vector128<sbyte> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<sbyte> left, Vector128<sbyte> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<byte> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<byte> left, Vector128<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<short> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<short> left, Vector128<short> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<ushort> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<ushort> left, Vector128<ushort> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<int> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<int> left, Vector128<int> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<uint> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<uint> left, Vector128<uint> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<long> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<long> left, Vector128<long> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<ulong> _mm_alignr_epi8/*Ssse3.AlignRight*/(Vector128<ulong> left, Vector128<ulong> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<short> _mm_hadd_epi16/*Ssse3.HorizontalAdd*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAdd(left, right);

        public static Vector128<int> _mm_hadd_epi32/*Ssse3.HorizontalAdd*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAdd(left, right);

        public static Vector128<short> _mm_hadds_epi16/*Ssse3.HorizontalAddSaturate*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAddSaturate(left, right);

        public static Vector128<short> _mm_hsub_epi16/*Ssse3.HorizontalSubtract*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtract(left, right);

        public static Vector128<int> _mm_hsub_epi32/*Ssse3.HorizontalSubtract*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtract(left, right);

        public static Vector128<short> _mm_hsubs_epi16/*Ssse3.HorizontalSubtractSaturate*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtractSaturate(left, right);

        public static Vector128<short> _mm_maddubs_epi16/*Ssse3.MultiplyAddAdjacent*/(Vector128<byte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Ssse3.MultiplyAddAdjacent(left, right);

        public static Vector128<short> _mm_mulhrs_epi16/*Ssse3.MultiplyHighRoundScale*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.MultiplyHighRoundScale(left, right);

        public static Vector128<sbyte> _mm_shuffle_epi8/*Ssse3.Shuffle*/(Vector128<sbyte> value, Vector128<sbyte> mask) => System.Runtime.Intrinsics.X86.Ssse3.Shuffle(value, mask);

        public static Vector128<byte> _mm_shuffle_epi8/*Ssse3.Shuffle*/(Vector128<byte> value, Vector128<byte> mask) => System.Runtime.Intrinsics.X86.Ssse3.Shuffle(value, mask);

        public static Vector128<sbyte> _mm_sign_epi8/*Ssse3.Sign*/(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Ssse3.Sign(left, right);

        public static Vector128<short> _mm_sign_epi16/*Ssse3.Sign*/(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.Sign(left, right);

        public static Vector128<int> _mm_sign_epi32/*Ssse3.Sign*/(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Ssse3.Sign(left, right);

    }
}