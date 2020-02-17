//GENERATED == DO NOT EDIT
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantUnsafeContext

// ReSharper disable once CheckNamespace
namespace Fast
{
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS3021 // Type or member does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute
    public static class Intrinsics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<byte> _mm_set1_epi8(byte value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<double> _mm_set1_pd(double value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<short> _mm_set1_epi16(short value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<int> _mm_set1_epi32(int value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<long> _mm_set1_epi64x(long value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<sbyte> _mm_set1_epi8(sbyte value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<float> _mm_set1_ps(float value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<ushort> _mm_set1_epi16(ushort value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<uint> _mm_set1_epi32(uint value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<ulong> _mm_set1_epi64x(ulong value) => System.Runtime.Intrinsics.Vector128.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<byte> _mm_setr_epi8(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15) => System.Runtime.Intrinsics.Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<double> _mm_setr_pd(double e0, double e1) => System.Runtime.Intrinsics.Vector128.Create(e0, e1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<short> _mm_setr_epi16(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7) => System.Runtime.Intrinsics.Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<int> _mm_setr_epi32(int e0, int e1, int e2, int e3) => System.Runtime.Intrinsics.Vector128.Create(e0, e1, e2, e3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<long> _mm_setr_epi64x(long e0, long e1) => System.Runtime.Intrinsics.Vector128.Create(e0, e1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<sbyte> _mm_setr_epi8(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15) => System.Runtime.Intrinsics.Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector128<float> _mm_setr_ps(float e0, float e1, float e2, float e3) => System.Runtime.Intrinsics.Vector128.Create(e0, e1, e2, e3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<ushort> _mm_setr_epi16(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7) => System.Runtime.Intrinsics.Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<uint> _mm_setr_epi32(uint e0, uint e1, uint e2, uint e3) => System.Runtime.Intrinsics.Vector128.Create(e0, e1, e2, e3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector128<ulong> _mm_setr_epi64x(ulong e0, ulong e1) => System.Runtime.Intrinsics.Vector128.Create(e0, e1);
        public static unsafe Vector128<int> _mm_setr_epi64(Vector64<int> lower, Vector64<int> upper) => System.Runtime.Intrinsics.Vector128.Create(lower, upper);
        [CLSCompliant(false)]
        public static unsafe Vector128<uint> _mm_setr_epi64(Vector64<uint> lower, Vector64<uint> upper) => System.Runtime.Intrinsics.Vector128.Create(lower, upper);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<byte> _mm256_set1_epi8(byte value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<double> _mm256_set1_pd(double value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<short> _mm256_set1_epi16(short value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<int> _mm256_set1_epi32(int value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<long> _mm256_set1_epi64x(long value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<sbyte> _mm256_set1_epi8(sbyte value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<float> _mm256_set1_ps(float value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<ushort> _mm256_set1_epi16(ushort value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<uint> _mm256_set1_epi32(uint value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<ulong> _mm256_set1_epi64x(ulong value) => System.Runtime.Intrinsics.Vector256.Create(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<byte> _mm256_setr_epi8(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15, byte e16, byte e17, byte e18, byte e19, byte e20, byte e21, byte e22, byte e23, byte e24, byte e25, byte e26, byte e27, byte e28, byte e29, byte e30, byte e31) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<double> _mm256_setr_pd(double e0, double e1, double e2, double e3) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<short> _mm256_setr_epi16(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7, short e8, short e9, short e10, short e11, short e12, short e13, short e14, short e15) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<int> _mm256_setr_epi32(int e0, int e1, int e2, int e3, int e4, int e5, int e6, int e7) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<long> _mm256_setr_epi64x(long e0, long e1, long e2, long e3) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<sbyte> _mm256_setr_epi8(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15, sbyte e16, sbyte e17, sbyte e18, sbyte e19, sbyte e20, sbyte e21, sbyte e22, sbyte e23, sbyte e24, sbyte e25, sbyte e26, sbyte e27, sbyte e28, sbyte e29, sbyte e30, sbyte e31) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<float> _mm256_setr_ps(float e0, float e1, float e2, float e3, float e4, float e5, float e6, float e7) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<ushort> _mm256_setr_epi16(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7, ushort e8, ushort e9, ushort e10, ushort e11, ushort e12, ushort e13, ushort e14, ushort e15) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<uint> _mm256_setr_epi32(uint e0, uint e1, uint e2, uint e3, uint e4, uint e5, uint e6, uint e7) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<ulong> _mm256_setr_epi64x(ulong e0, ulong e1, ulong e2, ulong e3) => System.Runtime.Intrinsics.Vector256.Create(e0, e1, e2, e3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<double> _mm256_setr_m128d(Vector128<double> lower, Vector128<double> upper) => System.Runtime.Intrinsics.Vector256.Create(lower, upper);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<int> _mm256_setr_m128i(Vector128<int> lower, Vector128<int> upper) => System.Runtime.Intrinsics.Vector256.Create(lower, upper);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<float> _mm256_setr_m128(Vector128<float> lower, Vector128<float> upper) => System.Runtime.Intrinsics.Vector256.Create(lower, upper);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static unsafe Vector256<uint> _mm256_setr_m128i(Vector128<uint> lower, Vector128<uint> upper) => System.Runtime.Intrinsics.Vector256.Create(lower, upper);
        public static unsafe Vector64<byte> _mm_set1_pi8(byte value) => System.Runtime.Intrinsics.Vector64.Create(value);
        public static unsafe Vector64<short> _mm_set1_pi16(short value) => System.Runtime.Intrinsics.Vector64.Create(value);
        public static unsafe Vector64<int> _mm_set1_pi32(int value) => System.Runtime.Intrinsics.Vector64.Create(value);
        [CLSCompliant(false)]
        public static unsafe Vector64<sbyte> _mm_set1_pi8(sbyte value) => System.Runtime.Intrinsics.Vector64.Create(value);
        [CLSCompliant(false)]
        public static unsafe Vector64<ushort> _mm_set1_pi16(ushort value) => System.Runtime.Intrinsics.Vector64.Create(value);
        [CLSCompliant(false)]
        public static unsafe Vector64<uint> _mm_set1_pi32(uint value) => System.Runtime.Intrinsics.Vector64.Create(value);
        public static unsafe Vector64<byte> _mm_setr_pi8(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7) => System.Runtime.Intrinsics.Vector64.Create(e0, e1, e2, e3, e4, e5, e6, e7);
        public static unsafe Vector64<short> _mm_setr_pi16(short e0, short e1, short e2, short e3) => System.Runtime.Intrinsics.Vector64.Create(e0, e1, e2, e3);
        public static unsafe Vector64<int> _mm_setr_pi32(int e0, int e1) => System.Runtime.Intrinsics.Vector64.Create(e0, e1);
        [CLSCompliant(false)]
        public static unsafe Vector64<sbyte> _mm_setr_pi8(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7) => System.Runtime.Intrinsics.Vector64.Create(e0, e1, e2, e3, e4, e5, e6, e7);
        [CLSCompliant(false)]
        public static unsafe Vector64<ushort> _mm_setr_pi16(ushort e0, ushort e1, ushort e2, ushort e3) => System.Runtime.Intrinsics.Vector64.Create(e0, e1, e2, e3);
        [CLSCompliant(false)]
        public static unsafe Vector64<uint> _mm_setr_pi32(uint e0, uint e1) => System.Runtime.Intrinsics.Vector64.Create(e0, e1);
        public static Vector128<byte> _mm_aesdec_si128(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.Decrypt(value, roundKey);

        public static Vector128<byte> _mm_aesdeclast_si128(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.DecryptLast(value, roundKey);

        public static Vector128<byte> _mm_aesenc_si128(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.Encrypt(value, roundKey);

        public static Vector128<byte> _mm_aesenclast_si128(Vector128<byte> value, Vector128<byte> roundKey) => System.Runtime.Intrinsics.X86.Aes.EncryptLast(value, roundKey);

        public static Vector128<byte> _mm_aesimc_si128(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Aes.InverseMixColumns(value);

        public static Vector128<byte> _mm_aeskeygenassist_si128(Vector128<byte> value, byte control) => System.Runtime.Intrinsics.X86.Aes.KeygenAssist(value, control);

        public static Vector256<float> _mm256_add_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Add(left, right);

        public static Vector256<double> _mm256_add_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Add(left, right);

        public static Vector256<float> _mm256_addsub_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.AddSubtract(left, right);

        public static Vector256<double> _mm256_addsub_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.AddSubtract(left, right);

        public static Vector256<float> _mm256_and_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.And(left, right);

        public static Vector256<double> _mm256_and_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.And(left, right);

        public static Vector256<float> _mm256_andnot_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.AndNot(left, right);

        public static Vector256<double> _mm256_andnot_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.AndNot(left, right);

        public static Vector256<float> _mm256_blend_ps(Vector256<float> left, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Blend(left, right, control);

        public static Vector256<double> _mm256_blend_pd(Vector256<double> left, Vector256<double> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Blend(left, right, control);

        public static Vector256<float> _mm256_blendv_ps(Vector256<float> left, Vector256<float> right, Vector256<float> mask) => System.Runtime.Intrinsics.X86.Avx.BlendVariable(left, right, mask);

        public static Vector256<double> _mm256_blendv_pd(Vector256<double> left, Vector256<double> right, Vector256<double> mask) => System.Runtime.Intrinsics.X86.Avx.BlendVariable(left, right, mask);

        public static unsafe Vector128<float> _mm_broadcast_ss(float* source) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector128(source);

        public static unsafe Vector256<float> _mm256_broadcast_ss(float* source) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector256(source);

        public static unsafe Vector256<double> _mm256_broadcast_sd(double* source) => System.Runtime.Intrinsics.X86.Avx.BroadcastScalarToVector256(source);

        public static unsafe Vector256<float> _mm256_broadcast_ps(float* address) => System.Runtime.Intrinsics.X86.Avx.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<double> _mm256_broadcast_pd(double* address) => System.Runtime.Intrinsics.X86.Avx.BroadcastVector128ToVector256(address);

        public static Vector256<float> _mm256_ceil_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Ceiling(value);

        public static Vector256<double> _mm256_ceil_pd(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.Ceiling(value);

        public static Vector128<float> _mm_cmp_ps(Vector128<float> left, Vector128<float> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector128<double> _mm_cmp_pd(Vector128<double> left, Vector128<double> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector256<float> _mm256_cmp_ps(Vector256<float> left, Vector256<float> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector256<double> _mm256_cmp_pd(Vector256<double> left, Vector256<double> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.Compare(left, right, mode);

        public static Vector128<double> _mm_cmp_sd(Vector128<double> left, Vector128<double> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.CompareScalar(left, right, mode);

        public static Vector128<float> _mm_cmp_ss(Vector128<float> left, Vector128<float> right, FloatComparisonMode mode) => System.Runtime.Intrinsics.X86.Avx.CompareScalar(left, right, mode);

        public static Vector128<int> _mm256_cvtpd_epi32(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Int32(value);

        public static Vector128<float> _mm256_cvtpd_ps(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Single(value);

        public static Vector256<int> _mm256_cvtps_epi32(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Int32(value);

        public static Vector256<float> _mm256_cvtepi32_ps(Vector256<int> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Single(value);

        public static Vector256<double> _mm256_cvtps_pd(Vector128<float> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Double(value);

        public static Vector256<double> _mm256_cvtepi32_pd(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Double(value);

        public static Vector128<int> _mm256_cvttpd_epi32(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector128Int32WithTruncation(value);

        public static Vector256<int> _mm256_cvttps_epi32(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.ConvertToVector256Int32WithTruncation(value);

        public static Vector256<float> _mm256_div_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Divide(left, right);

        public static Vector256<double> _mm256_div_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Divide(left, right);

        public static Vector256<float> _mm256_dp_ps(Vector256<float> left, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.DotProduct(left, right, control);

        public static Vector256<float> _mm256_moveldup_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.DuplicateEvenIndexed(value);

        public static Vector256<double> _mm256_movedup_pd(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.DuplicateEvenIndexed(value);

        public static Vector256<float> _mm256_movehdup_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.DuplicateOddIndexed(value);

        public static Vector128<byte> _mm256_extractf128_si256(Vector256<byte> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<sbyte> _mm256_extractf128_si256(Vector256<sbyte> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<short> _mm256_extractf128_si256(Vector256<short> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<ushort> _mm256_extractf128_si256(Vector256<ushort> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<int> _mm256_extractf128_si256(Vector256<int> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<uint> _mm256_extractf128_si256(Vector256<uint> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<long> _mm256_extractf128_si256(Vector256<long> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<ulong> _mm256_extractf128_si256(Vector256<ulong> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<float> _mm256_extractf128_ps(Vector256<float> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector128<double> _mm256_extractf128_pd(Vector256<double> value, byte index) => System.Runtime.Intrinsics.X86.Avx.ExtractVector128(value, index);

        public static Vector256<float> _mm256_floor_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Floor(value);

        public static Vector256<double> _mm256_floor_pd(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.Floor(value);

        public static Vector256<float> _mm256_hadd_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalAdd(left, right);

        public static Vector256<double> _mm256_hadd_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalAdd(left, right);

        public static Vector256<float> _mm256_hsub_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalSubtract(left, right);

        public static Vector256<double> _mm256_hsub_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.HorizontalSubtract(left, right);

        public static Vector256<byte> _mm256_insertf128_si256(Vector256<byte> value, Vector128<byte> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<sbyte> _mm256_insertf128_si256(Vector256<sbyte> value, Vector128<sbyte> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<short> _mm256_insertf128_si256(Vector256<short> value, Vector128<short> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<ushort> _mm256_insertf128_si256(Vector256<ushort> value, Vector128<ushort> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<int> _mm256_insertf128_si256(Vector256<int> value, Vector128<int> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<uint> _mm256_insertf128_si256(Vector256<uint> value, Vector128<uint> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<long> _mm256_insertf128_si256(Vector256<long> value, Vector128<long> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<ulong> _mm256_insertf128_si256(Vector256<ulong> value, Vector128<ulong> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<float> _mm256_insertf128_ps(Vector256<float> value, Vector128<float> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static Vector256<double> _mm256_insertf128_pd(Vector256<double> value, Vector128<double> data, byte index) => System.Runtime.Intrinsics.X86.Avx.InsertVector128(value, data, index);

        public static unsafe Vector256<sbyte> _mm256_loadu_si256(sbyte* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<byte> _mm256_loadu_si256(byte* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<short> _mm256_loadu_si256(short* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<ushort> _mm256_loadu_si256(ushort* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<int> _mm256_loadu_si256(int* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<uint> _mm256_loadu_si256(uint* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<long> _mm256_loadu_si256(long* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<ulong> _mm256_loadu_si256(ulong* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<float> _mm256_loadu_ps(float* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<double> _mm256_loadu_pd(double* address) => System.Runtime.Intrinsics.X86.Avx.LoadVector256(address);

        public static unsafe Vector256<sbyte> _mm256_load_si256(sbyte* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<byte> _mm256_load_si256(byte* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<short> _mm256_load_si256(short* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<ushort> _mm256_load_si256(ushort* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<int> _mm256_load_si256(int* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<uint> _mm256_load_si256(uint* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<long> _mm256_load_si256(long* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<ulong> _mm256_load_si256(ulong* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<float> _mm256_load_ps(float* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<double> _mm256_load_pd(double* address) => System.Runtime.Intrinsics.X86.Avx.LoadAlignedVector256(address);

        public static unsafe Vector256<sbyte> _mm256_lddqu_si256(sbyte* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<byte> _mm256_lddqu_si256(byte* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<short> _mm256_lddqu_si256(short* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<ushort> _mm256_lddqu_si256(ushort* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<int> _mm256_lddqu_si256(int* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<uint> _mm256_lddqu_si256(uint* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<long> _mm256_lddqu_si256(long* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector256<ulong> _mm256_lddqu_si256(ulong* address) => System.Runtime.Intrinsics.X86.Avx.LoadDquVector256(address);

        public static unsafe Vector128<float> _mm_maskload_ps(float* address, Vector128<float> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe Vector128<double> _mm_maskload_pd(double* address, Vector128<double> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe Vector256<float> _mm256_maskload_ps(float* address, Vector256<float> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe Vector256<double> _mm256_maskload_pd(double* address, Vector256<double> mask) => System.Runtime.Intrinsics.X86.Avx.MaskLoad(address, mask);

        public static unsafe void _mm_maskstore_ps(float* address, Vector128<float> mask, Vector128<float> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_pd(double* address, Vector128<double> mask, Vector128<double> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_ps(float* address, Vector256<float> mask, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_pd(double* address, Vector256<double> mask, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.MaskStore(address, mask, source);

        public static Vector256<float> _mm256_max_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Max(left, right);

        public static Vector256<double> _mm256_max_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Max(left, right);

        public static Vector256<float> _mm256_min_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Min(left, right);

        public static Vector256<double> _mm256_min_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Min(left, right);

        public static int _mm256_movemask_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.MoveMask(value);

        public static int _mm256_movemask_pd(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.MoveMask(value);

        public static Vector256<float> _mm256_mul_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Multiply(left, right);

        public static Vector256<double> _mm256_mul_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Multiply(left, right);

        public static Vector256<float> _mm256_or_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Or(left, right);

        public static Vector256<double> _mm256_or_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Or(left, right);

        public static Vector128<float> _mm_permute_ps(Vector128<float> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector128<double> _mm_permute_pd(Vector128<double> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector256<float> _mm256_permute_ps(Vector256<float> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector256<double> _mm256_permute_pd(Vector256<double> value, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute(value, control);

        public static Vector256<byte> _mm256_permute2f128_si256(Vector256<byte> left, Vector256<byte> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<sbyte> _mm256_permute2f128_si256(Vector256<sbyte> left, Vector256<sbyte> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<short> _mm256_permute2f128_si256(Vector256<short> left, Vector256<short> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<ushort> _mm256_permute2f128_si256(Vector256<ushort> left, Vector256<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<int> _mm256_permute2f128_si256(Vector256<int> left, Vector256<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<uint> _mm256_permute2f128_si256(Vector256<uint> left, Vector256<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<long> _mm256_permute2f128_si256(Vector256<long> left, Vector256<long> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<ulong> _mm256_permute2f128_si256(Vector256<ulong> left, Vector256<ulong> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<float> _mm256_permute2f128_ps(Vector256<float> left, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector256<double> _mm256_permute2f128_pd(Vector256<double> left, Vector256<double> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Permute2x128(left, right, control);

        public static Vector128<float> _mm_permutevar_ps(Vector128<float> left, Vector128<int> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector128<double> _mm_permutevar_pd(Vector128<double> left, Vector128<long> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector256<float> _mm256_permutevar_ps(Vector256<float> left, Vector256<int> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector256<double> _mm256_permutevar_pd(Vector256<double> left, Vector256<long> control) => System.Runtime.Intrinsics.X86.Avx.PermuteVar(left, control);

        public static Vector256<float> _mm256_rcp_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Reciprocal(value);

        public static Vector256<float> _mm256_rsqrt_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.ReciprocalSqrt(value);

        public static Vector256<float> _mm256_round_ps_ToNearestInteger(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNearestInteger(value);

        public static Vector256<float> _mm256_round_ps_ToNegativeInfinity(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNegativeInfinity(value);

        public static Vector256<float> _mm256_round_ps_ToPositiveInfinity(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToPositiveInfinity(value);

        public static Vector256<float> _mm256_round_ps_ToZero(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundToZero(value);

        public static Vector256<float> _mm256_round_ps_CurrentDirection(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.RoundCurrentDirection(value);

        public static Vector256<double> _mm256_round_pd_ToNearestInteger(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNearestInteger(value);

        public static Vector256<double> _mm256_round_pd_ToNegativeInfinity(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToNegativeInfinity(value);

        public static Vector256<double> _mm256_round_pd_ToPositiveInfinity(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToPositiveInfinity(value);

        public static Vector256<double> _mm256_round_pd_ToZero(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundToZero(value);

        public static Vector256<double> _mm256_round_pd_CurrentDirection(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.RoundCurrentDirection(value);

        public static Vector256<float> _mm256_shuffle_ps(Vector256<float> value, Vector256<float> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Shuffle(value, right, control);

        public static Vector256<double> _mm256_shuffle_pd(Vector256<double> value, Vector256<double> right, byte control) => System.Runtime.Intrinsics.X86.Avx.Shuffle(value, right, control);

        public static Vector256<float> _mm256_sqrt_ps(Vector256<float> value) => System.Runtime.Intrinsics.X86.Avx.Sqrt(value);

        public static Vector256<double> _mm256_sqrt_pd(Vector256<double> value) => System.Runtime.Intrinsics.X86.Avx.Sqrt(value);

        public static unsafe void _mm256_store_si256(sbyte* address, Vector256<sbyte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256(byte* address, Vector256<byte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256(short* address, Vector256<short> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256(ushort* address, Vector256<ushort> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256(int* address, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256(uint* address, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256(long* address, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_si256(ulong* address, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_ps(float* address, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_store_pd(double* address, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.StoreAligned(address, source);

        public static unsafe void _mm256_stream_si256(sbyte* address, Vector256<sbyte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256(byte* address, Vector256<byte> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256(short* address, Vector256<short> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256(ushort* address, Vector256<ushort> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256(int* address, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256(uint* address, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256(long* address, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_si256(ulong* address, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_ps(float* address, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_stream_pd(double* address, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm256_storeu_si256(sbyte* address, Vector256<sbyte> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256(byte* address, Vector256<byte> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256(short* address, Vector256<short> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256(ushort* address, Vector256<ushort> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256(int* address, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256(uint* address, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256(long* address, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_si256(ulong* address, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_ps(float* address, Vector256<float> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static unsafe void _mm256_storeu_pd(double* address, Vector256<double> source) => System.Runtime.Intrinsics.X86.Avx.Store(address, source);

        public static Vector256<float> _mm256_sub_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Subtract(left, right);

        public static Vector256<double> _mm256_sub_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Subtract(left, right);

        public static bool _mm_testc_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm_testc_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_si256(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm256_testc_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.TestC(left, right);

        public static bool _mm_testnzc_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm_testnzc_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_si256(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm256_testnzc_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.TestNotZAndNotC(left, right);

        public static bool _mm_testz_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm_testz_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_si256(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static bool _mm256_testz_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.TestZ(left, right);

        public static Vector256<float> _mm256_unpackhi_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.UnpackHigh(left, right);

        public static Vector256<double> _mm256_unpackhi_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.UnpackHigh(left, right);

        public static Vector256<float> _mm256_unpacklo_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.UnpackLow(left, right);

        public static Vector256<double> _mm256_unpacklo_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.UnpackLow(left, right);

        public static Vector256<float> _mm256_xor_ps(Vector256<float> left, Vector256<float> right) => System.Runtime.Intrinsics.X86.Avx.Xor(left, right);

        public static Vector256<double> _mm256_xor_pd(Vector256<double> left, Vector256<double> right) => System.Runtime.Intrinsics.X86.Avx.Xor(left, right);

        public static Vector256<byte> _mm256_abs_epi8(Vector256<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.Abs(value);

        public static Vector256<ushort> _mm256_abs_epi16(Vector256<short> value) => System.Runtime.Intrinsics.X86.Avx2.Abs(value);

        public static Vector256<uint> _mm256_abs_epi32(Vector256<int> value) => System.Runtime.Intrinsics.X86.Avx2.Abs(value);

        public static Vector256<sbyte> _mm256_add_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<byte> _mm256_add_epi8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<short> _mm256_add_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<ushort> _mm256_add_epi16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<int> _mm256_add_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<uint> _mm256_add_epi32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<long> _mm256_add_epi64(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<ulong> _mm256_add_epi64(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Add(left, right);

        public static Vector256<sbyte> _mm256_adds_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<byte> _mm256_adds_epu8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<short> _mm256_adds_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<ushort> _mm256_adds_epu16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.AddSaturate(left, right);

        public static Vector256<sbyte> _mm256_alignr_epi8(Vector256<sbyte> left, Vector256<sbyte> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<byte> _mm256_alignr_epi8(Vector256<byte> left, Vector256<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<short> _mm256_alignr_epi8(Vector256<short> left, Vector256<short> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<ushort> _mm256_alignr_epi8(Vector256<ushort> left, Vector256<ushort> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<int> _mm256_alignr_epi8(Vector256<int> left, Vector256<int> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<uint> _mm256_alignr_epi8(Vector256<uint> left, Vector256<uint> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<long> _mm256_alignr_epi8(Vector256<long> left, Vector256<long> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<ulong> _mm256_alignr_epi8(Vector256<ulong> left, Vector256<ulong> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.AlignRight(left, right, mask);

        public static Vector256<sbyte> _mm256_and_si256(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<byte> _mm256_and_si256(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<short> _mm256_and_si256(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<ushort> _mm256_and_si256(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<int> _mm256_and_si256(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<uint> _mm256_and_si256(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<long> _mm256_and_si256(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<ulong> _mm256_and_si256(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.And(left, right);

        public static Vector256<sbyte> _mm256_andnot_si256(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<byte> _mm256_andnot_si256(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<short> _mm256_andnot_si256(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<ushort> _mm256_andnot_si256(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<int> _mm256_andnot_si256(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<uint> _mm256_andnot_si256(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<long> _mm256_andnot_si256(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<ulong> _mm256_andnot_si256(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.AndNot(left, right);

        public static Vector256<byte> _mm256_avg_epu8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Average(left, right);

        public static Vector256<ushort> _mm256_avg_epu16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Average(left, right);

        public static Vector128<int> _mm_blend_epi32(Vector128<int> left, Vector128<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector128<uint> _mm_blend_epi32(Vector128<uint> left, Vector128<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<short> _mm256_blend_epi16(Vector256<short> left, Vector256<short> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<ushort> _mm256_blend_epi16(Vector256<ushort> left, Vector256<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<int> _mm256_blend_epi32(Vector256<int> left, Vector256<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<uint> _mm256_blend_epi32(Vector256<uint> left, Vector256<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Blend(left, right, control);

        public static Vector256<sbyte> _mm256_blendv_epi8(Vector256<sbyte> left, Vector256<sbyte> right, Vector256<sbyte> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<byte> _mm256_blendv_epi8(Vector256<byte> left, Vector256<byte> right, Vector256<byte> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<short> _mm256_blendv_epi8(Vector256<short> left, Vector256<short> right, Vector256<short> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<ushort> _mm256_blendv_epi8(Vector256<ushort> left, Vector256<ushort> right, Vector256<ushort> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<int> _mm256_blendv_epi8(Vector256<int> left, Vector256<int> right, Vector256<int> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<uint> _mm256_blendv_epi8(Vector256<uint> left, Vector256<uint> right, Vector256<uint> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<long> _mm256_blendv_epi8(Vector256<long> left, Vector256<long> right, Vector256<long> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector256<ulong> _mm256_blendv_epi8(Vector256<ulong> left, Vector256<ulong> right, Vector256<ulong> mask) => System.Runtime.Intrinsics.X86.Avx2.BlendVariable(left, right, mask);

        public static Vector128<byte> _mm_broadcastb_epi8(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<sbyte> _mm_broadcastb_epi8(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<short> _mm_broadcastw_epi16(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<ushort> _mm_broadcastw_epi16(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<int> _mm_broadcastd_epi32(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<uint> _mm_broadcastd_epi32(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<long> _mm_broadcastq_epi64(Vector128<long> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<ulong> _mm_broadcastq_epi64(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<float> _mm_broadcastss_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static Vector128<double> _mm_broadcastsd_pd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(value);

        public static unsafe Vector128<byte> _mm_broadcastb_epi8(byte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<sbyte> _mm_broadcastb_epi8(sbyte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<short> _mm_broadcastw_epi16(short* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<ushort> _mm_broadcastw_epi16(ushort* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<int> _mm_broadcastd_epi32(int* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<uint> _mm_broadcastd_epi32(uint* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<long> _mm_broadcastq_epi64(long* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static unsafe Vector128<ulong> _mm_broadcastq_epi64(ulong* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector128(source);

        public static Vector256<byte> _mm256_broadcastb_epi8(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<sbyte> _mm256_broadcastb_epi8(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<short> _mm256_broadcastw_epi16(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<ushort> _mm256_broadcastw_epi16(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<int> _mm256_broadcastd_epi32(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<uint> _mm256_broadcastd_epi32(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<long> _mm256_broadcastq_epi64(Vector128<long> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<ulong> _mm256_broadcastq_epi64(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<float> _mm256_broadcastss_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static Vector256<double> _mm256_broadcastsd_pd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(value);

        public static unsafe Vector256<byte> _mm256_broadcastb_epi8(byte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<sbyte> _mm256_broadcastb_epi8(sbyte* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<short> _mm256_broadcastw_epi16(short* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<ushort> _mm256_broadcastw_epi16(ushort* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<int> _mm256_broadcastd_epi32(int* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<uint> _mm256_broadcastd_epi32(uint* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<long> _mm256_broadcastq_epi64(long* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<ulong> _mm256_broadcastq_epi64(ulong* source) => System.Runtime.Intrinsics.X86.Avx2.BroadcastScalarToVector256(source);

        public static unsafe Vector256<sbyte> _mm256_broadcastsi128_si256(sbyte* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<byte> _mm256_broadcastsi128_si256(byte* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<short> _mm256_broadcastsi128_si256(short* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<ushort> _mm256_broadcastsi128_si256(ushort* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<int> _mm256_broadcastsi128_si256(int* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<uint> _mm256_broadcastsi128_si256(uint* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<long> _mm256_broadcastsi128_si256(long* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static unsafe Vector256<ulong> _mm256_broadcastsi128_si256(ulong* address) => System.Runtime.Intrinsics.X86.Avx2.BroadcastVector128ToVector256(address);

        public static Vector256<sbyte> _mm256_cmpeq_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<byte> _mm256_cmpeq_epi8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<short> _mm256_cmpeq_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<ushort> _mm256_cmpeq_epi16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<int> _mm256_cmpeq_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<uint> _mm256_cmpeq_epi32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<long> _mm256_cmpeq_epi64(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<ulong> _mm256_cmpeq_epi64(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.CompareEqual(left, right);

        public static Vector256<sbyte> _mm256_cmpgt_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static Vector256<short> _mm256_cmpgt_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static Vector256<int> _mm256_cmpgt_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static Vector256<long> _mm256_cmpgt_epi64(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.CompareGreaterThan(left, right);

        public static int _mm256_cvtsi256_si32(Vector256<int> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToInt32(value);

        public static uint _mm256_cvtsi256_si32(Vector256<uint> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToUInt32(value);

        public static Vector256<short> _mm256_cvtepi8_epi16(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int16(value);

        public static Vector256<short> _mm256_cvtepu8_epi16(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int16(value);

        public static Vector256<int> _mm256_cvtepi8_epi32(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<int> _mm256_cvtepu8_epi32(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<int> _mm256_cvtepi16_epi32(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<int> _mm256_cvtepu16_epi32(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int32(value);

        public static Vector256<long> _mm256_cvtepi8_epi64(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepu8_epi64(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepi16_epi64(Vector128<short> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepu16_epi64(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepi32_epi64(Vector128<int> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector256<long> _mm256_cvtepu32_epi64(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Avx2.ConvertToVector256Int64(value);

        public static Vector128<sbyte> _mm256_extracti128_si256(Vector256<sbyte> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<byte> _mm256_extracti128_si256(Vector256<byte> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<short> _mm256_extracti128_si256(Vector256<short> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<ushort> _mm256_extracti128_si256(Vector256<ushort> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<int> _mm256_extracti128_si256(Vector256<int> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<uint> _mm256_extracti128_si256(Vector256<uint> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<long> _mm256_extracti128_si256(Vector256<long> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static Vector128<ulong> _mm256_extracti128_si256(Vector256<ulong> value, byte index) => System.Runtime.Intrinsics.X86.Avx2.ExtractVector128(value, index);

        public static unsafe Vector128<int> _mm_i32gather_epi32(int* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<uint> _mm_i32gather_epi32(uint* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<long> _mm_i32gather_epi64(long* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<ulong> _mm_i32gather_epi64(ulong* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<float> _mm_i32gather_ps(float* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<double> _mm_i32gather_pd(double* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<int> _mm_i64gather_epi32(int* baseAddress, Vector128<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<uint> _mm_i64gather_epi32(uint* baseAddress, Vector128<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<long> _mm_i64gather_epi64(long* baseAddress, Vector128<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<ulong> _mm_i64gather_epi64(ulong* baseAddress, Vector128<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<float> _mm_i64gather_ps(float* baseAddress, Vector128<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<double> _mm_i64gather_pd(double* baseAddress, Vector128<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector256<int> _mm256_i32gather_epi32(int* baseAddress, Vector256<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<uint> _mm256_i32gather_epi32(uint* baseAddress, Vector256<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<long> _mm256_i32gather_epi64(long* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<ulong> _mm256_i32gather_epi64(ulong* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<float> _mm256_i32gather_ps(float* baseAddress, Vector256<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<double> _mm256_i32gather_pd(double* baseAddress, Vector128<int> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector128<int> _mm256_i64gather_epi32(int* baseAddress, Vector256<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector128<uint> _mm256_i64gather_epi32(uint* baseAddress, Vector256<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector256<long> _mm256_i64gather_epi64(long* baseAddress, Vector256<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector256<ulong> _mm256_i64gather_epi64(ulong* baseAddress, Vector256<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector128<float> _mm256_i64gather_ps(float* baseAddress, Vector256<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector128(baseAddress, index, scale);
        public static unsafe Vector256<double> _mm256_i64gather_pd(double* baseAddress, Vector256<long> index, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherVector256(baseAddress, index, scale);
        public static unsafe Vector128<int> _mm_mask_i32gather_epi32(Vector128<int> source, int* baseAddress, Vector128<int> index, Vector128<int> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<uint> _mm_mask_i32gather_epi32(Vector128<uint> source, uint* baseAddress, Vector128<int> index, Vector128<uint> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<long> _mm_mask_i32gather_epi64(Vector128<long> source, long* baseAddress, Vector128<int> index, Vector128<long> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<ulong> _mm_mask_i32gather_epi64(Vector128<ulong> source, ulong* baseAddress, Vector128<int> index, Vector128<ulong> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<float> _mm_mask_i32gather_ps(Vector128<float> source, float* baseAddress, Vector128<int> index, Vector128<float> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<double> _mm_mask_i32gather_pd(Vector128<double> source, double* baseAddress, Vector128<int> index, Vector128<double> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<int> _mm_mask_i64gather_epi32(Vector128<int> source, int* baseAddress, Vector128<long> index, Vector128<int> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<uint> _mm_mask_i64gather_epi32(Vector128<uint> source, uint* baseAddress, Vector128<long> index, Vector128<uint> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<long> _mm_mask_i64gather_epi64(Vector128<long> source, long* baseAddress, Vector128<long> index, Vector128<long> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<ulong> _mm_mask_i64gather_epi64(Vector128<ulong> source, ulong* baseAddress, Vector128<long> index, Vector128<ulong> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<float> _mm_mask_i64gather_ps(Vector128<float> source, float* baseAddress, Vector128<long> index, Vector128<float> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<double> _mm_mask_i64gather_pd(Vector128<double> source, double* baseAddress, Vector128<long> index, Vector128<double> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<int> _mm256_mask_i32gather_epi32(Vector256<int> source, int* baseAddress, Vector256<int> index, Vector256<int> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<uint> _mm256_mask_i32gather_epi32(Vector256<uint> source, uint* baseAddress, Vector256<int> index, Vector256<uint> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<long> _mm256_mask_i32gather_epi64(Vector256<long> source, long* baseAddress, Vector128<int> index, Vector256<long> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<ulong> _mm256_mask_i32gather_epi64(Vector256<ulong> source, ulong* baseAddress, Vector128<int> index, Vector256<ulong> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<float> _mm256_mask_i32gather_ps(Vector256<float> source, float* baseAddress, Vector256<int> index, Vector256<float> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<double> _mm256_mask_i32gather_pd(Vector256<double> source, double* baseAddress, Vector128<int> index, Vector256<double> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<int> _mm256_mask_i64gather_epi32(Vector128<int> source, int* baseAddress, Vector256<long> index, Vector128<int> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<uint> _mm256_mask_i64gather_epi32(Vector128<uint> source, uint* baseAddress, Vector256<long> index, Vector128<uint> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<long> _mm256_mask_i64gather_epi64(Vector256<long> source, long* baseAddress, Vector256<long> index, Vector256<long> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<ulong> _mm256_mask_i64gather_epi64(Vector256<ulong> source, ulong* baseAddress, Vector256<long> index, Vector256<ulong> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static unsafe Vector128<float> _mm256_mask_i64gather_ps(Vector128<float> source, float* baseAddress, Vector256<long> index, Vector128<float> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
        public static unsafe Vector256<double> _mm256_mask_i64gather_pd(Vector256<double> source, double* baseAddress, Vector256<long> index, Vector256<double> mask, byte scale) => System.Runtime.Intrinsics.X86.Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
        public static Vector256<short> _mm256_hadd_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAdd(left, right);

        public static Vector256<int> _mm256_hadd_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAdd(left, right);

        public static Vector256<short> _mm256_hadds_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalAddSaturate(left, right);

        public static Vector256<short> _mm256_hsub_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtract(left, right);

        public static Vector256<int> _mm256_hsub_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtract(left, right);

        public static Vector256<short> _mm256_hsubs_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.HorizontalSubtractSaturate(left, right);

        public static Vector256<sbyte> _mm256_inserti128_si256(Vector256<sbyte> value, Vector128<sbyte> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<byte> _mm256_inserti128_si256(Vector256<byte> value, Vector128<byte> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<short> _mm256_inserti128_si256(Vector256<short> value, Vector128<short> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<ushort> _mm256_inserti128_si256(Vector256<ushort> value, Vector128<ushort> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<int> _mm256_inserti128_si256(Vector256<int> value, Vector128<int> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<uint> _mm256_inserti128_si256(Vector256<uint> value, Vector128<uint> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<long> _mm256_inserti128_si256(Vector256<long> value, Vector128<long> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static Vector256<ulong> _mm256_inserti128_si256(Vector256<ulong> value, Vector128<ulong> data, byte index) => System.Runtime.Intrinsics.X86.Avx2.InsertVector128(value, data, index);

        public static unsafe Vector256<sbyte> _mm256_stream_load_si256(sbyte* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<byte> _mm256_stream_load_si256(byte* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<short> _mm256_stream_load_si256(short* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<ushort> _mm256_stream_load_si256(ushort* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<int> _mm256_stream_load_si256(int* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<uint> _mm256_stream_load_si256(uint* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<long> _mm256_stream_load_si256(long* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector256<ulong> _mm256_stream_load_si256(ulong* address) => System.Runtime.Intrinsics.X86.Avx2.LoadAlignedVector256NonTemporal(address);

        public static unsafe Vector128<int> _mm_maskload_epi32(int* address, Vector128<int> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector128<uint> _mm_maskload_epi32(uint* address, Vector128<uint> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector128<long> _mm_maskload_epi64(long* address, Vector128<long> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector128<ulong> _mm_maskload_epi64(ulong* address, Vector128<ulong> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<int> _mm256_maskload_epi32(int* address, Vector256<int> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<uint> _mm256_maskload_epi32(uint* address, Vector256<uint> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<long> _mm256_maskload_epi64(long* address, Vector256<long> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe Vector256<ulong> _mm256_maskload_epi64(ulong* address, Vector256<ulong> mask) => System.Runtime.Intrinsics.X86.Avx2.MaskLoad(address, mask);

        public static unsafe void _mm_maskstore_epi32(int* address, Vector128<int> mask, Vector128<int> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_epi32(uint* address, Vector128<uint> mask, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_epi64(long* address, Vector128<long> mask, Vector128<long> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm_maskstore_epi64(ulong* address, Vector128<ulong> mask, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi32(int* address, Vector256<int> mask, Vector256<int> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi32(uint* address, Vector256<uint> mask, Vector256<uint> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi64(long* address, Vector256<long> mask, Vector256<long> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static unsafe void _mm256_maskstore_epi64(ulong* address, Vector256<ulong> mask, Vector256<ulong> source) => System.Runtime.Intrinsics.X86.Avx2.MaskStore(address, mask, source);

        public static Vector256<int> _mm256_madd_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyAddAdjacent(left, right);

        public static Vector256<short> _mm256_maddubs_epi16(Vector256<byte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyAddAdjacent(left, right);

        public static Vector256<sbyte> _mm256_max_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<byte> _mm256_max_epu8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<short> _mm256_max_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<ushort> _mm256_max_epu16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<int> _mm256_max_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<uint> _mm256_max_epu32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Max(left, right);

        public static Vector256<sbyte> _mm256_min_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<byte> _mm256_min_epu8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<short> _mm256_min_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<ushort> _mm256_min_epu16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<int> _mm256_min_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static Vector256<uint> _mm256_min_epu32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Min(left, right);

        public static int _mm256_movemask_epi8(Vector256<sbyte> value) => System.Runtime.Intrinsics.X86.Avx2.MoveMask(value);

        public static int _mm256_movemask_epi8(Vector256<byte> value) => System.Runtime.Intrinsics.X86.Avx2.MoveMask(value);

        public static Vector256<ushort> _mm256_mpsadbw_epu8(Vector256<byte> left, Vector256<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Avx2.MultipleSumAbsoluteDifferences(left, right, mask);

        public static Vector256<long> _mm256_mul_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Multiply(left, right);

        public static Vector256<ulong> _mm256_mul_epu32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Multiply(left, right);

        public static Vector256<short> _mm256_mulhi_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHigh(left, right);

        public static Vector256<ushort> _mm256_mulhi_epu16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHigh(left, right);

        public static Vector256<short> _mm256_mulhrs_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyHighRoundScale(left, right);

        public static Vector256<short> _mm256_mullo_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<ushort> _mm256_mullo_epi16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<int> _mm256_mullo_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<uint> _mm256_mullo_epi32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.MultiplyLow(left, right);

        public static Vector256<sbyte> _mm256_or_si256(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<byte> _mm256_or_si256(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<short> _mm256_or_si256(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<ushort> _mm256_or_si256(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<int> _mm256_or_si256(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<uint> _mm256_or_si256(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<long> _mm256_or_si256(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<ulong> _mm256_or_si256(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Or(left, right);

        public static Vector256<sbyte> _mm256_packs_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.PackSignedSaturate(left, right);

        public static Vector256<short> _mm256_packs_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.PackSignedSaturate(left, right);

        public static Vector256<byte> _mm256_packus_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.PackUnsignedSaturate(left, right);

        public static Vector256<ushort> _mm256_packus_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.PackUnsignedSaturate(left, right);

        public static Vector256<sbyte> _mm256_permute2x128_si256(Vector256<sbyte> left, Vector256<sbyte> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<byte> _mm256_permute2x128_si256(Vector256<byte> left, Vector256<byte> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<short> _mm256_permute2x128_si256(Vector256<short> left, Vector256<short> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<ushort> _mm256_permute2x128_si256(Vector256<ushort> left, Vector256<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<int> _mm256_permute2x128_si256(Vector256<int> left, Vector256<int> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<uint> _mm256_permute2x128_si256(Vector256<uint> left, Vector256<uint> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<long> _mm256_permute2x128_si256(Vector256<long> left, Vector256<long> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<ulong> _mm256_permute2x128_si256(Vector256<ulong> left, Vector256<ulong> right, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute2x128(left, right, control);

        public static Vector256<long> _mm256_permute4x64_epi64(Vector256<long> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(value, control);

        public static Vector256<ulong> _mm256_permute4x64_epi64(Vector256<ulong> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(value, control);

        public static Vector256<double> _mm256_permute4x64_pd(Vector256<double> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Permute4x64(value, control);

        public static Vector256<int> _mm256_permutevar8x32_epi32(Vector256<int> left, Vector256<int> control) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(left, control);

        public static Vector256<uint> _mm256_permutevar8x32_epi32(Vector256<uint> left, Vector256<uint> control) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(left, control);

        public static Vector256<float> _mm256_permutevar8x32_ps(Vector256<float> left, Vector256<int> control) => System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(left, control);

        public static Vector256<short> _mm256_sll_epi16(Vector256<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ushort> _mm256_sll_epi16(Vector256<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<int> _mm256_sll_epi32(Vector256<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<uint> _mm256_sll_epi32(Vector256<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<long> _mm256_sll_epi64(Vector256<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ulong> _mm256_sll_epi64(Vector256<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<short> _mm256_slli_epi16(Vector256<short> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ushort> _mm256_slli_epi16(Vector256<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<int> _mm256_slli_epi32(Vector256<int> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<uint> _mm256_slli_epi32(Vector256<uint> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<long> _mm256_slli_epi64(Vector256<long> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<ulong> _mm256_slli_epi64(Vector256<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical(value, count);

        public static Vector256<sbyte> _mm256_bslli_epi128(Vector256<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<byte> _mm256_bslli_epi128(Vector256<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<short> _mm256_bslli_epi128(Vector256<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<ushort> _mm256_bslli_epi128(Vector256<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_bslli_epi128(Vector256<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<uint> _mm256_bslli_epi128(Vector256<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<long> _mm256_bslli_epi128(Vector256<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<ulong> _mm256_bslli_epi128(Vector256<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_sllv_epi32(Vector256<int> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<uint> _mm256_sllv_epi32(Vector256<uint> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<long> _mm256_sllv_epi64(Vector256<long> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<ulong> _mm256_sllv_epi64(Vector256<ulong> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<int> _mm_sllv_epi32(Vector128<int> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<uint> _mm_sllv_epi32(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<long> _mm_sllv_epi64(Vector128<long> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector128<ulong> _mm_sllv_epi64(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftLeftLogicalVariable(value, count);

        public static Vector256<short> _mm256_sra_epi16(Vector256<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<int> _mm256_sra_epi32(Vector256<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<short> _mm256_srai_epi16(Vector256<short> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<int> _mm256_srai_epi32(Vector256<int> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmetic(value, count);

        public static Vector256<int> _mm256_srav_epi32(Vector256<int> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmeticVariable(value, count);

        public static Vector128<int> _mm_srav_epi32(Vector128<int> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightArithmeticVariable(value, count);

        public static Vector256<short> _mm256_srl_epi16(Vector256<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ushort> _mm256_srl_epi16(Vector256<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<int> _mm256_srl_epi32(Vector256<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<uint> _mm256_srl_epi32(Vector256<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<long> _mm256_srl_epi64(Vector256<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ulong> _mm256_srl_epi64(Vector256<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<short> _mm256_srli_epi16(Vector256<short> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ushort> _mm256_srli_epi16(Vector256<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<int> _mm256_srli_epi32(Vector256<int> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<uint> _mm256_srli_epi32(Vector256<uint> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<long> _mm256_srli_epi64(Vector256<long> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<ulong> _mm256_srli_epi64(Vector256<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical(value, count);

        public static Vector256<sbyte> _mm256_bsrli_epi128(Vector256<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<byte> _mm256_bsrli_epi128(Vector256<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<short> _mm256_bsrli_epi128(Vector256<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<ushort> _mm256_bsrli_epi128(Vector256<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_bsrli_epi128(Vector256<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<uint> _mm256_bsrli_epi128(Vector256<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<long> _mm256_bsrli_epi128(Vector256<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<ulong> _mm256_bsrli_epi128(Vector256<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector256<int> _mm256_srlv_epi32(Vector256<int> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<uint> _mm256_srlv_epi32(Vector256<uint> value, Vector256<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<long> _mm256_srlv_epi64(Vector256<long> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<ulong> _mm256_srlv_epi64(Vector256<ulong> value, Vector256<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<int> _mm_srlv_epi32(Vector128<int> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<uint> _mm_srlv_epi32(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<long> _mm_srlv_epi64(Vector128<long> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector128<ulong> _mm_srlv_epi64(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Avx2.ShiftRightLogicalVariable(value, count);

        public static Vector256<sbyte> _mm256_shuffle_epi8(Vector256<sbyte> value, Vector256<sbyte> mask) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, mask);

        public static Vector256<byte> _mm256_shuffle_epi8(Vector256<byte> value, Vector256<byte> mask) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, mask);

        public static Vector256<int> _mm256_shuffle_epi32(Vector256<int> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, control);

        public static Vector256<uint> _mm256_shuffle_epi32(Vector256<uint> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.Shuffle(value, control);

        public static Vector256<short> _mm256_shufflehi_epi16(Vector256<short> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleHigh(value, control);

        public static Vector256<ushort> _mm256_shufflehi_epi16(Vector256<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleHigh(value, control);

        public static Vector256<short> _mm256_shufflelo_epi16(Vector256<short> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleLow(value, control);

        public static Vector256<ushort> _mm256_shufflelo_epi16(Vector256<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Avx2.ShuffleLow(value, control);

        public static Vector256<sbyte> _mm256_sign_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Sign(left, right);

        public static Vector256<short> _mm256_sign_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Sign(left, right);

        public static Vector256<int> _mm256_sign_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Sign(left, right);

        public static Vector256<sbyte> _mm256_sub_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<byte> _mm256_sub_epi8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<short> _mm256_sub_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<ushort> _mm256_sub_epi16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<int> _mm256_sub_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<uint> _mm256_sub_epi32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<long> _mm256_sub_epi64(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<ulong> _mm256_sub_epi64(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Subtract(left, right);

        public static Vector256<sbyte> _mm256_subs_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<short> _mm256_subs_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<byte> _mm256_subs_epu8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<ushort> _mm256_subs_epu16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.SubtractSaturate(left, right);

        public static Vector256<ushort> _mm256_sad_epu8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.SumAbsoluteDifferences(left, right);

        public static Vector256<sbyte> _mm256_unpackhi_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<byte> _mm256_unpackhi_epi8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<short> _mm256_unpackhi_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<ushort> _mm256_unpackhi_epi16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<int> _mm256_unpackhi_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<uint> _mm256_unpackhi_epi32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<long> _mm256_unpackhi_epi64(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<ulong> _mm256_unpackhi_epi64(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackHigh(left, right);

        public static Vector256<sbyte> _mm256_unpacklo_epi8(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<byte> _mm256_unpacklo_epi8(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<short> _mm256_unpacklo_epi16(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<ushort> _mm256_unpacklo_epi16(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<int> _mm256_unpacklo_epi32(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<uint> _mm256_unpacklo_epi32(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<long> _mm256_unpacklo_epi64(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<ulong> _mm256_unpacklo_epi64(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.UnpackLow(left, right);

        public static Vector256<sbyte> _mm256_xor_si256(Vector256<sbyte> left, Vector256<sbyte> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<byte> _mm256_xor_si256(Vector256<byte> left, Vector256<byte> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<short> _mm256_xor_si256(Vector256<short> left, Vector256<short> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<ushort> _mm256_xor_si256(Vector256<ushort> left, Vector256<ushort> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<int> _mm256_xor_si256(Vector256<int> left, Vector256<int> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<uint> _mm256_xor_si256(Vector256<uint> left, Vector256<uint> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<long> _mm256_xor_si256(Vector256<long> left, Vector256<long> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static Vector256<ulong> _mm256_xor_si256(Vector256<ulong> left, Vector256<ulong> right) => System.Runtime.Intrinsics.X86.Avx2.Xor(left, right);

        public static uint _andn_u32(uint left, uint right) => System.Runtime.Intrinsics.X86.Bmi1.AndNot(left, right);

        public static uint _bextr_u32(uint value, byte start, byte length) => System.Runtime.Intrinsics.X86.Bmi1.BitFieldExtract(value, start, length);

        public static uint _bextr2_u32(uint value, ushort control) => System.Runtime.Intrinsics.X86.Bmi1.BitFieldExtract(value, control);

        public static uint _blsi_u32(uint value) => System.Runtime.Intrinsics.X86.Bmi1.ExtractLowestSetBit(value);

        public static uint _blsmsk_u32(uint value) => System.Runtime.Intrinsics.X86.Bmi1.GetMaskUpToLowestSetBit(value);

        public static uint _blsr_u32(uint value) => System.Runtime.Intrinsics.X86.Bmi1.ResetLowestSetBit(value);

        public static uint _mm_tzcnt_32(uint value) => System.Runtime.Intrinsics.X86.Bmi1.TrailingZeroCount(value);

        public static ulong _andn_u64(ulong left, ulong right) => System.Runtime.Intrinsics.X86.Bmi1.X64.AndNot(left, right);

        public static ulong _bextr_u64(ulong value, byte start, byte length) => System.Runtime.Intrinsics.X86.Bmi1.X64.BitFieldExtract(value, start, length);

        public static ulong _bextr2_u64(ulong value, ushort control) => System.Runtime.Intrinsics.X86.Bmi1.X64.BitFieldExtract(value, control);

        public static ulong _blsi_u64(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.ExtractLowestSetBit(value);

        public static ulong _blsmsk_u64(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.GetMaskUpToLowestSetBit(value);

        public static ulong _blsr_u64(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.ResetLowestSetBit(value);

        public static ulong _mm_tzcnt_64(ulong value) => System.Runtime.Intrinsics.X86.Bmi1.X64.TrailingZeroCount(value);

        public static uint _bzhi_u32(uint value, uint index) => System.Runtime.Intrinsics.X86.Bmi2.ZeroHighBits(value, index);

        public static uint _mulx_u32(uint left, uint right) => System.Runtime.Intrinsics.X86.Bmi2.MultiplyNoFlags(left, right);

        public static unsafe uint _mulx_u32(uint left, uint right, uint* low) => System.Runtime.Intrinsics.X86.Bmi2.MultiplyNoFlags(left, right, low);

        public static uint _pdep_u32(uint value, uint mask) => System.Runtime.Intrinsics.X86.Bmi2.ParallelBitDeposit(value, mask);

        public static uint _pext_u32(uint value, uint mask) => System.Runtime.Intrinsics.X86.Bmi2.ParallelBitExtract(value, mask);

        public static ulong _bzhi_u64(ulong value, ulong index) => System.Runtime.Intrinsics.X86.Bmi2.X64.ZeroHighBits(value, index);

        public static ulong _mulx_u64(ulong left, ulong right) => System.Runtime.Intrinsics.X86.Bmi2.X64.MultiplyNoFlags(left, right);

        public static unsafe ulong _mulx_u64(ulong left, ulong right, ulong* low) => System.Runtime.Intrinsics.X86.Bmi2.X64.MultiplyNoFlags(left, right, low);

        public static ulong _pdep_u64(ulong value, ulong mask) => System.Runtime.Intrinsics.X86.Bmi2.X64.ParallelBitDeposit(value, mask);

        public static ulong _pext_u64(ulong value, ulong mask) => System.Runtime.Intrinsics.X86.Bmi2.X64.ParallelBitExtract(value, mask);

        public static Vector128<float> _mm_fmadd_ps(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector128<double> _mm_fmadd_pd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector256<float> _mm256_fmadd_ps(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector256<double> _mm256_fmadd_pd(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAdd(a, b, c);

        public static Vector128<float> _mm_fmadd_ss(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddScalar(a, b, c);

        public static Vector128<double> _mm_fmadd_sd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddScalar(a, b, c);

        public static Vector128<float> _mm_fmaddsub_ps(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector128<double> _mm_fmaddsub_pd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector256<float> _mm256_fmaddsub_ps(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector256<double> _mm256_fmaddsub_pd(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddSubtract(a, b, c);

        public static Vector128<float> _mm_fmsub_ps(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector128<double> _mm_fmsub_pd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector256<float> _mm256_fmsub_ps(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector256<double> _mm256_fmsub_pd(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtract(a, b, c);

        public static Vector128<float> _mm_fmsub_ss(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractScalar(a, b, c);

        public static Vector128<double> _mm_fmsub_sd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractScalar(a, b, c);

        public static Vector128<float> _mm_fmsubadd_ps(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector128<double> _mm_fmsubadd_pd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector256<float> _mm256_fmsubadd_ps(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector256<double> _mm256_fmsubadd_pd(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractAdd(a, b, c);

        public static Vector128<float> _mm_fnmadd_ps(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector128<double> _mm_fnmadd_pd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector256<float> _mm256_fnmadd_ps(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector256<double> _mm256_fnmadd_pd(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegated(a, b, c);

        public static Vector128<float> _mm_fnmadd_ss(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegatedScalar(a, b, c);

        public static Vector128<double> _mm_fnmadd_sd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplyAddNegatedScalar(a, b, c);

        public static Vector128<float> _mm_fnmsub_ps(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector128<double> _mm_fnmsub_pd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector256<float> _mm256_fnmsub_ps(Vector256<float> a, Vector256<float> b, Vector256<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector256<double> _mm256_fnmsub_pd(Vector256<double> a, Vector256<double> b, Vector256<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegated(a, b, c);

        public static Vector128<float> _mm_fnmsub_ss(Vector128<float> a, Vector128<float> b, Vector128<float> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegatedScalar(a, b, c);

        public static Vector128<double> _mm_fnmsub_sd(Vector128<double> a, Vector128<double> b, Vector128<double> c) => System.Runtime.Intrinsics.X86.Fma.MultiplySubtractNegatedScalar(a, b, c);

        public static uint _lzcnt_u32(uint value) => System.Runtime.Intrinsics.X86.Lzcnt.LeadingZeroCount(value);

        public static ulong _lzcnt_u64(ulong value) => System.Runtime.Intrinsics.X86.Lzcnt.X64.LeadingZeroCount(value);

        public static Vector128<long> _mm_clmulepi64_si128(Vector128<long> left, Vector128<long> right, byte control) => System.Runtime.Intrinsics.X86.Pclmulqdq.CarrylessMultiply(left, right, control);

        public static Vector128<ulong> _mm_clmulepi64_si128(Vector128<ulong> left, Vector128<ulong> right, byte control) => System.Runtime.Intrinsics.X86.Pclmulqdq.CarrylessMultiply(left, right, control);

        public static uint _mm_popcnt_u32(uint value) => System.Runtime.Intrinsics.X86.Popcnt.PopCount(value);

        public static ulong _mm_popcnt_u64(ulong value) => System.Runtime.Intrinsics.X86.Popcnt.X64.PopCount(value);

        public static Vector128<float> _mm_add_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Add(left, right);

        public static Vector128<float> _mm_add_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.AddScalar(left, right);

        public static Vector128<float> _mm_and_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.And(left, right);

        public static Vector128<float> _mm_andnot_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.AndNot(left, right);

        public static Vector128<float> _mm_cmpeq_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareEqual(left, right);

        public static bool _mm_comieq_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedEqual(left, right);

        public static bool _mm_ucomieq_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedEqual(left, right);

        public static Vector128<float> _mm_cmpeq_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarEqual(left, right);

        public static Vector128<float> _mm_cmpgt_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareGreaterThan(left, right);

        public static bool _mm_comigt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedGreaterThan(left, right);

        public static bool _mm_ucomigt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedGreaterThan(left, right);

        public static Vector128<float> _mm_cmpgt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarGreaterThan(left, right);

        public static Vector128<float> _mm_cmpge_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareGreaterThanOrEqual(left, right);

        public static bool _mm_comige_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedGreaterThanOrEqual(left, right);

        public static bool _mm_ucomige_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpge_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmplt_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareLessThan(left, right);

        public static bool _mm_comilt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedLessThan(left, right);

        public static bool _mm_ucomilt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedLessThan(left, right);

        public static Vector128<float> _mm_cmplt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarLessThan(left, right);

        public static Vector128<float> _mm_cmple_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareLessThanOrEqual(left, right);

        public static bool _mm_comile_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedLessThanOrEqual(left, right);

        public static bool _mm_ucomile_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmple_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpneq_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotEqual(left, right);

        public static bool _mm_comineq_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrderedNotEqual(left, right);

        public static bool _mm_ucomineq_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnorderedNotEqual(left, right);

        public static Vector128<float> _mm_cmpneq_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotEqual(left, right);

        public static Vector128<float> _mm_cmpngt_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotGreaterThan(left, right);

        public static Vector128<float> _mm_cmpngt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotGreaterThan(left, right);

        public static Vector128<float> _mm_cmpnge_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpnge_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotGreaterThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpnlt_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotLessThan(left, right);

        public static Vector128<float> _mm_cmpnlt_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotLessThan(left, right);

        public static Vector128<float> _mm_cmpnle_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareNotLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpnle_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarNotLessThanOrEqual(left, right);

        public static Vector128<float> _mm_cmpord_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareOrdered(left, right);

        public static Vector128<float> _mm_cmpord_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarOrdered(left, right);

        public static Vector128<float> _mm_cmpunord_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareUnordered(left, right);

        public static Vector128<float> _mm_cmpunord_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.CompareScalarUnordered(left, right);

        public static int _mm_cvtss_si32(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ConvertToInt32(value);

        public static Vector128<float> _mm_cvtsi32_ss(Vector128<float> upper, int value) => System.Runtime.Intrinsics.X86.Sse.ConvertScalarToVector128Single(upper, value);

        public static int _mm_cvttss_si32(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ConvertToInt32WithTruncation(value);

        public static Vector128<float> _mm_div_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Divide(left, right);

        public static Vector128<float> _mm_div_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.DivideScalar(left, right);

        public static unsafe Vector128<float> _mm_loadu_ps(float* address) => System.Runtime.Intrinsics.X86.Sse.LoadVector128(address);

        public static unsafe Vector128<float> _mm_load_ss(float* address) => System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(address);

        public static unsafe Vector128<float> _mm_load_ps(float* address) => System.Runtime.Intrinsics.X86.Sse.LoadAlignedVector128(address);

        public static unsafe Vector128<float> _mm_loadh_pi(Vector128<float> lower, float* address) => System.Runtime.Intrinsics.X86.Sse.LoadHigh(lower, address);

        public static unsafe Vector128<float> _mm_loadl_pi(Vector128<float> upper, float* address) => System.Runtime.Intrinsics.X86.Sse.LoadLow(upper, address);

        public static Vector128<float> _mm_max_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Max(left, right);

        public static Vector128<float> _mm_max_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MaxScalar(left, right);

        public static Vector128<float> _mm_min_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Min(left, right);

        public static Vector128<float> _mm_min_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MinScalar(left, right);

        public static Vector128<float> _mm_move_ss(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.MoveScalar(upper, value);

        public static Vector128<float> _mm_movehl_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MoveHighToLow(left, right);

        public static Vector128<float> _mm_movelh_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MoveLowToHigh(left, right);

        public static int _mm_movemask_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.MoveMask(value);

        public static Vector128<float> _mm_mul_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Multiply(left, right);

        public static Vector128<float> _mm_mul_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(left, right);

        public static Vector128<float> _mm_or_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Or(left, right);

        public static unsafe void _mm_prefetch0(void* address) => System.Runtime.Intrinsics.X86.Sse.Prefetch0(address);

        public static unsafe void _mm_prefetch1(void* address) => System.Runtime.Intrinsics.X86.Sse.Prefetch1(address);

        public static unsafe void _mm_prefetch2(void* address) => System.Runtime.Intrinsics.X86.Sse.Prefetch2(address);

        public static unsafe void _mm_prefetchl(void* address) => System.Runtime.Intrinsics.X86.Sse.PrefetchNonTemporal(address);

        public static Vector128<float> _mm_rcp_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.Reciprocal(value);

        public static Vector128<float> _mm_rcp_ss(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalScalar(value);

        public static Vector128<float> _mm_rcp_ss(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalScalar(upper, value);

        public static Vector128<float> _mm_rsqrt_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrt(value);

        public static Vector128<float> _mm_rsqrt_ss(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrtScalar(value);

        public static Vector128<float> _mm_rsqrt_ss(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.ReciprocalSqrtScalar(upper, value);

        public static Vector128<float> _mm_shuffle_ps(Vector128<float> left, Vector128<float> right, byte control) => System.Runtime.Intrinsics.X86.Sse.Shuffle(left, right, control);

        public static Vector128<float> _mm_sqrt_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.Sqrt(value);

        public static Vector128<float> _mm_sqrt_ss(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.SqrtScalar(value);

        public static Vector128<float> _mm_sqrt_ss(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.SqrtScalar(upper, value);

        public static unsafe void _mm_store_ps(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreAligned(address, source);

        public static unsafe void _mm_stream_ps(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_storeu_ps(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.Store(address, source);

        public static void _mm_sfence() => System.Runtime.Intrinsics.X86.Sse.StoreFence();

        public static unsafe void _mm_store_ss(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreScalar(address, source);

        public static unsafe void _mm_storeh_pi(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreHigh(address, source);

        public static unsafe void _mm_storel_pi(float* address, Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse.StoreLow(address, source);

        public static Vector128<float> _mm_sub_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Subtract(left, right);

        public static Vector128<float> _mm_sub_ss(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.SubtractScalar(left, right);

        public static Vector128<float> _mm_unpackhi_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.UnpackHigh(left, right);

        public static Vector128<float> _mm_unpacklo_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.UnpackLow(left, right);

        public static Vector128<float> _mm_xor_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse.Xor(left, right);

        public static long _mm_cvtss_si64(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertToInt64(value);

        public static Vector128<float> _mm_cvtsi64_ss(Vector128<float> upper, long value) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertScalarToVector128Single(upper, value);

        public static long _mm_cvttss_si64(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse.X64.ConvertToInt64WithTruncation(value);

        public static Vector128<byte> _mm_add_epi8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<sbyte> _mm_add_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<short> _mm_add_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<ushort> _mm_add_epi16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<int> _mm_add_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<uint> _mm_add_epi32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<long> _mm_add_epi64(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<ulong> _mm_add_epi64(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<double> _mm_add_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Add(left, right);

        public static Vector128<double> _mm_add_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.AddScalar(left, right);

        public static Vector128<sbyte> _mm_adds_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<byte> _mm_adds_epu8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<short> _mm_adds_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<ushort> _mm_adds_epu16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.AddSaturate(left, right);

        public static Vector128<byte> _mm_and_si128(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<sbyte> _mm_and_si128(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<short> _mm_and_si128(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<ushort> _mm_and_si128(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<int> _mm_and_si128(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<uint> _mm_and_si128(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<long> _mm_and_si128(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<ulong> _mm_and_si128(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<double> _mm_and_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.And(left, right);

        public static Vector128<byte> _mm_andnot_si128(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<sbyte> _mm_andnot_si128(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<short> _mm_andnot_si128(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<ushort> _mm_andnot_si128(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<int> _mm_andnot_si128(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<uint> _mm_andnot_si128(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<long> _mm_andnot_si128(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<ulong> _mm_andnot_si128(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<double> _mm_andnot_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.AndNot(left, right);

        public static Vector128<byte> _mm_avg_epu8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Average(left, right);

        public static Vector128<ushort> _mm_avg_epu16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Average(left, right);

        public static Vector128<sbyte> _mm_cmpeq_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<byte> _mm_cmpeq_epi8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<short> _mm_cmpeq_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<ushort> _mm_cmpeq_epi16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<int> _mm_cmpeq_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<uint> _mm_cmpeq_epi32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static Vector128<double> _mm_cmpeq_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareEqual(left, right);

        public static bool _mm_comieq_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedEqual(left, right);

        public static bool _mm_ucomieq_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedEqual(left, right);

        public static Vector128<double> _mm_cmpeq_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarEqual(left, right);

        public static Vector128<sbyte> _mm_cmpgt_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static Vector128<short> _mm_cmpgt_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static Vector128<int> _mm_cmpgt_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static Vector128<double> _mm_cmpgt_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThan(left, right);

        public static bool _mm_comigt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedGreaterThan(left, right);

        public static bool _mm_ucomigt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedGreaterThan(left, right);

        public static Vector128<double> _mm_cmpgt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarGreaterThan(left, right);

        public static Vector128<double> _mm_cmpge_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareGreaterThanOrEqual(left, right);

        public static bool _mm_comige_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedGreaterThanOrEqual(left, right);

        public static bool _mm_ucomige_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedGreaterThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpge_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarGreaterThanOrEqual(left, right);

        public static Vector128<sbyte> _mm_cmplt_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static Vector128<short> _mm_cmplt_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static Vector128<int> _mm_cmplt_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static Vector128<double> _mm_cmplt_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThan(left, right);

        public static bool _mm_comilt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedLessThan(left, right);

        public static bool _mm_ucomilt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedLessThan(left, right);

        public static Vector128<double> _mm_cmplt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarLessThan(left, right);

        public static Vector128<double> _mm_cmple_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareLessThanOrEqual(left, right);

        public static bool _mm_comile_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedLessThanOrEqual(left, right);

        public static bool _mm_ucomile_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmple_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpneq_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotEqual(left, right);

        public static bool _mm_comineq_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrderedNotEqual(left, right);

        public static bool _mm_ucomineq_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnorderedNotEqual(left, right);

        public static Vector128<double> _mm_cmpneq_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotEqual(left, right);

        public static Vector128<double> _mm_cmpngt_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotGreaterThan(left, right);

        public static Vector128<double> _mm_cmpngt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotGreaterThan(left, right);

        public static Vector128<double> _mm_cmpnge_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotGreaterThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpnge_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotGreaterThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpnlt_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotLessThan(left, right);

        public static Vector128<double> _mm_cmpnlt_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotLessThan(left, right);

        public static Vector128<double> _mm_cmpnle_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareNotLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpnle_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarNotLessThanOrEqual(left, right);

        public static Vector128<double> _mm_cmpord_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareOrdered(left, right);

        public static Vector128<double> _mm_cmpord_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarOrdered(left, right);

        public static Vector128<double> _mm_cmpunord_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareUnordered(left, right);

        public static Vector128<double> _mm_cmpunord_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.CompareScalarUnordered(left, right);

        public static Vector128<int> _mm_cvtps_epi32(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtpd_epi32(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32(value);

        public static Vector128<float> _mm_cvtepi32_ps(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Single(value);

        public static Vector128<float> _mm_cvtpd_ps(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Single(value);

        public static Vector128<double> _mm_cvtepi32_pd(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Double(value);

        public static Vector128<double> _mm_cvtps_pd(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Double(value);

        public static int _mm_cvtsd_si32(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32(value);

        public static int _mm_cvtsi128_si32(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32(value);

        public static uint _mm_cvtsi128_si32(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToUInt32(value);

        public static Vector128<double> _mm_cvtsi32_sd(Vector128<double> upper, int value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Double(upper, value);

        public static Vector128<double> _mm_cvtss_sd(Vector128<double> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Double(upper, value);

        public static Vector128<int> _mm_cvtsi32_si128(int value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Int32(value);

        public static Vector128<float> _mm_cvtsd_ss(Vector128<float> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128Single(upper, value);

        public static Vector128<uint> _mm_cvtsi32_si128(uint value) => System.Runtime.Intrinsics.X86.Sse2.ConvertScalarToVector128UInt32(value);

        public static Vector128<int> _mm_cvttps_epi32(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32WithTruncation(value);

        public static Vector128<int> _mm_cvttpd_epi32(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToVector128Int32WithTruncation(value);

        public static int _mm_cvttsd_si32(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.ConvertToInt32WithTruncation(value);

        public static Vector128<double> _mm_div_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Divide(left, right);

        public static Vector128<double> _mm_div_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.DivideScalar(left, right);

        public static ushort _mm_extract_epi16(Vector128<ushort> value, byte index) => System.Runtime.Intrinsics.X86.Sse2.Extract(value, index);

        public static Vector128<short> _mm_insert_epi16(Vector128<short> value, short data, byte index) => System.Runtime.Intrinsics.X86.Sse2.Insert(value, data, index);

        public static Vector128<ushort> _mm_insert_epi16(Vector128<ushort> value, ushort data, byte index) => System.Runtime.Intrinsics.X86.Sse2.Insert(value, data, index);

        public static unsafe Vector128<sbyte> _mm_loadu_si128(sbyte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<byte> _mm_loadu_si128(byte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<short> _mm_loadu_si128(short* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<ushort> _mm_loadu_si128(ushort* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<int> _mm_loadu_si128(int* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<uint> _mm_loadu_si128(uint* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<long> _mm_loadu_si128(long* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<ulong> _mm_loadu_si128(ulong* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<double> _mm_loadu_pd(double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadVector128(address);

        public static unsafe Vector128<double> _mm_load_sd(double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<sbyte> _mm_load_si128(sbyte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<byte> _mm_load_si128(byte* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<short> _mm_load_si128(short* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<ushort> _mm_load_si128(ushort* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<int> _mm_load_si128(int* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<uint> _mm_load_si128(uint* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<long> _mm_load_si128(long* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<ulong> _mm_load_si128(ulong* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static unsafe Vector128<double> _mm_load_pd(double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadAlignedVector128(address);

        public static void _mm_lfence() => System.Runtime.Intrinsics.X86.Sse2.LoadFence();

        public static unsafe Vector128<double> _mm_loadh_pd(Vector128<double> lower, double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadHigh(lower, address);

        public static unsafe Vector128<double> _mm_loadl_pd(Vector128<double> upper, double* address) => System.Runtime.Intrinsics.X86.Sse2.LoadLow(upper, address);

        public static unsafe Vector128<int> _mm_loadl_epi32(int* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<uint> _mm_loadl_epi32(uint* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<long> _mm_loadl_epi64(long* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe Vector128<ulong> _mm_loadl_epi64(ulong* address) => System.Runtime.Intrinsics.X86.Sse2.LoadScalarVector128(address);

        public static unsafe void _mm_maskmoveu_si128(Vector128<sbyte> source, Vector128<sbyte> mask, sbyte* address) => System.Runtime.Intrinsics.X86.Sse2.MaskMove(source, mask, address);

        public static unsafe void _mm_maskmoveu_si128(Vector128<byte> source, Vector128<byte> mask, byte* address) => System.Runtime.Intrinsics.X86.Sse2.MaskMove(source, mask, address);

        public static Vector128<byte> _mm_max_epu8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Max(left, right);

        public static Vector128<short> _mm_max_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Max(left, right);

        public static Vector128<double> _mm_max_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Max(left, right);

        public static Vector128<double> _mm_max_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.MaxScalar(left, right);

        public static void _mm_mfence() => System.Runtime.Intrinsics.X86.Sse2.MemoryFence();

        public static Vector128<byte> _mm_min_epu8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Min(left, right);

        public static Vector128<short> _mm_min_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Min(left, right);

        public static Vector128<double> _mm_min_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Min(left, right);

        public static Vector128<double> _mm_min_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.MinScalar(left, right);

        public static Vector128<double> _mm_move_sd(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(upper, value);

        public static int _mm_movemask_epi8(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(value);

        public static int _mm_movemask_epi8(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(value);

        public static int _mm_movemask_pd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.MoveMask(value);

        public static Vector128<long> _mm_move_epi64(Vector128<long> value) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(value);

        public static Vector128<ulong> _mm_move_epi64(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Sse2.MoveScalar(value);

        public static Vector128<ulong> _mm_mul_epu32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Multiply(left, right);

        public static Vector128<double> _mm_mul_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Multiply(left, right);

        public static Vector128<double> _mm_mul_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyScalar(left, right);

        public static Vector128<short> _mm_mulhi_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyHigh(left, right);

        public static Vector128<ushort> _mm_mulhi_epu16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyHigh(left, right);

        public static Vector128<int> _mm_madd_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyAddAdjacent(left, right);

        public static Vector128<short> _mm_mullo_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyLow(left, right);

        public static Vector128<ushort> _mm_mullo_epi16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.MultiplyLow(left, right);

        public static Vector128<byte> _mm_or_si128(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<sbyte> _mm_or_si128(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<short> _mm_or_si128(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<ushort> _mm_or_si128(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<int> _mm_or_si128(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<uint> _mm_or_si128(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<long> _mm_or_si128(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<ulong> _mm_or_si128(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<double> _mm_or_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Or(left, right);

        public static Vector128<sbyte> _mm_packs_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.PackSignedSaturate(left, right);

        public static Vector128<short> _mm_packs_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.PackSignedSaturate(left, right);

        public static Vector128<byte> _mm_packus_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.PackUnsignedSaturate(left, right);

        public static Vector128<ushort> _mm_sad_epu8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.SumAbsoluteDifferences(left, right);

        public static Vector128<int> _mm_shuffle_epi32(Vector128<int> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(value, control);

        public static Vector128<uint> _mm_shuffle_epi32(Vector128<uint> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(value, control);

        public static Vector128<double> _mm_shuffle_pd(Vector128<double> left, Vector128<double> right, byte control) => System.Runtime.Intrinsics.X86.Sse2.Shuffle(left, right, control);

        public static Vector128<short> _mm_shufflehi_epi16(Vector128<short> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleHigh(value, control);

        public static Vector128<ushort> _mm_shufflehi_epi16(Vector128<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleHigh(value, control);

        public static Vector128<short> _mm_shufflelo_epi16(Vector128<short> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleLow(value, control);

        public static Vector128<ushort> _mm_shufflelo_epi16(Vector128<ushort> value, byte control) => System.Runtime.Intrinsics.X86.Sse2.ShuffleLow(value, control);

        public static Vector128<short> _mm_sll_epi16(Vector128<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ushort> _mm_sll_epi16(Vector128<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<int> _mm_sll_epi32(Vector128<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<uint> _mm_sll_epi32(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<long> _mm_sll_epi64(Vector128<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ulong> _mm_sll_epi64(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<short> _mm_slli_epi16(Vector128<short> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ushort> _mm_slli_epi16(Vector128<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<int> _mm_slli_epi32(Vector128<int> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<uint> _mm_slli_epi32(Vector128<uint> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<long> _mm_slli_epi64(Vector128<long> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<ulong> _mm_slli_epi64(Vector128<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical(value, count);

        public static Vector128<sbyte> _mm_bslli_si128(Vector128<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<byte> _mm_bslli_si128(Vector128<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<short> _mm_bslli_si128(Vector128<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<ushort> _mm_bslli_si128(Vector128<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<int> _mm_bslli_si128(Vector128<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<uint> _mm_bslli_si128(Vector128<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<long> _mm_bslli_si128(Vector128<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<ulong> _mm_bslli_si128(Vector128<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(value, numBytes);

        public static Vector128<short> _mm_sra_epi16(Vector128<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<int> _mm_sra_epi32(Vector128<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<short> _mm_srai_epi16(Vector128<short> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<int> _mm_srai_epi32(Vector128<int> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightArithmetic(value, count);

        public static Vector128<short> _mm_srl_epi16(Vector128<short> value, Vector128<short> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ushort> _mm_srl_epi16(Vector128<ushort> value, Vector128<ushort> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<int> _mm_srl_epi32(Vector128<int> value, Vector128<int> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<uint> _mm_srl_epi32(Vector128<uint> value, Vector128<uint> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<long> _mm_srl_epi64(Vector128<long> value, Vector128<long> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ulong> _mm_srl_epi64(Vector128<ulong> value, Vector128<ulong> count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<short> _mm_srli_epi16(Vector128<short> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ushort> _mm_srli_epi16(Vector128<ushort> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<int> _mm_srli_epi32(Vector128<int> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<uint> _mm_srli_epi32(Vector128<uint> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<long> _mm_srli_epi64(Vector128<long> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<ulong> _mm_srli_epi64(Vector128<ulong> value, byte count) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical(value, count);

        public static Vector128<sbyte> _mm_bsrli_si128(Vector128<sbyte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<byte> _mm_bsrli_si128(Vector128<byte> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<short> _mm_bsrli_si128(Vector128<short> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<ushort> _mm_bsrli_si128(Vector128<ushort> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<int> _mm_bsrli_si128(Vector128<int> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<uint> _mm_bsrli_si128(Vector128<uint> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<long> _mm_bsrli_si128(Vector128<long> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<ulong> _mm_bsrli_si128(Vector128<ulong> value, byte numBytes) => System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(value, numBytes);

        public static Vector128<double> _mm_sqrt_pd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.Sqrt(value);

        public static Vector128<double> _mm_sqrt_sd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.SqrtScalar(value);

        public static Vector128<double> _mm_sqrt_sd(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.SqrtScalar(upper, value);

        public static unsafe void _mm_store_sd(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar(address, source);

        public static unsafe void _mm_storel_epi64(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar(address, source);

        public static unsafe void _mm_storel_epi64(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.StoreScalar(address, source);

        public static unsafe void _mm_store_si128(sbyte* address, Vector128<sbyte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128(byte* address, Vector128<byte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128(short* address, Vector128<short> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128(ushort* address, Vector128<ushort> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128(int* address, Vector128<int> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128(uint* address, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_si128(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_store_pd(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAligned(address, source);

        public static unsafe void _mm_stream_si128(sbyte* address, Vector128<sbyte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128(byte* address, Vector128<byte> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128(short* address, Vector128<short> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128(ushort* address, Vector128<ushort> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128(int* address, Vector128<int> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128(uint* address, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_si128(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_stream_pd(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreAlignedNonTemporal(address, source);

        public static unsafe void _mm_storeu_si128(sbyte* address, Vector128<sbyte> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128(byte* address, Vector128<byte> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128(short* address, Vector128<short> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128(ushort* address, Vector128<ushort> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128(int* address, Vector128<int> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128(uint* address, Vector128<uint> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128(long* address, Vector128<long> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_si128(ulong* address, Vector128<ulong> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeu_pd(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.Store(address, source);

        public static unsafe void _mm_storeh_pd(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreHigh(address, source);

        public static unsafe void _mm_storel_pd(double* address, Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse2.StoreLow(address, source);

        public static unsafe void _mm_stream_si32(int* address, int value) => System.Runtime.Intrinsics.X86.Sse2.StoreNonTemporal(address, value);

        public static unsafe void _mm_stream_si32(uint* address, uint value) => System.Runtime.Intrinsics.X86.Sse2.StoreNonTemporal(address, value);

        public static Vector128<byte> _mm_sub_epi8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<sbyte> _mm_sub_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<short> _mm_sub_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<ushort> _mm_sub_epi16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<int> _mm_sub_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<uint> _mm_sub_epi32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<long> _mm_sub_epi64(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<ulong> _mm_sub_epi64(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<double> _mm_sub_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Subtract(left, right);

        public static Vector128<double> _mm_sub_sd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractScalar(left, right);

        public static Vector128<sbyte> _mm_subs_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<short> _mm_subs_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<byte> _mm_subs_epu8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<ushort> _mm_subs_epu16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.SubtractSaturate(left, right);

        public static Vector128<byte> _mm_unpackhi_epi8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<sbyte> _mm_unpackhi_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<short> _mm_unpackhi_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<ushort> _mm_unpackhi_epi16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<int> _mm_unpackhi_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<uint> _mm_unpackhi_epi32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<long> _mm_unpackhi_epi64(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<ulong> _mm_unpackhi_epi64(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<double> _mm_unpackhi_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackHigh(left, right);

        public static Vector128<byte> _mm_unpacklo_epi8(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<sbyte> _mm_unpacklo_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<short> _mm_unpacklo_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<ushort> _mm_unpacklo_epi16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<int> _mm_unpacklo_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<uint> _mm_unpacklo_epi32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<long> _mm_unpacklo_epi64(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<ulong> _mm_unpacklo_epi64(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<double> _mm_unpacklo_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.UnpackLow(left, right);

        public static Vector128<byte> _mm_xor_si128(Vector128<byte> left, Vector128<byte> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<sbyte> _mm_xor_si128(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<short> _mm_xor_si128(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<ushort> _mm_xor_si128(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<int> _mm_xor_si128(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<uint> _mm_xor_si128(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<long> _mm_xor_si128(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<ulong> _mm_xor_si128(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static Vector128<double> _mm_xor_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse2.Xor(left, right);

        public static long _mm_cvtsd_si64(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64(value);

        public static long _mm_cvtsi128_si64(Vector128<long> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64(value);

        public static ulong _mm_cvtsi128_si64(Vector128<ulong> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToUInt64(value);

        public static Vector128<double> _mm_cvtsi64_sd(Vector128<double> upper, long value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128Double(upper, value);

        public static Vector128<long> _mm_cvtsi64_si128(long value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128Int64(value);

        public static Vector128<ulong> _mm_cvtsi64_si128(ulong value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertScalarToVector128UInt64(value);

        public static long _mm_cvttsd_si64(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse2.X64.ConvertToInt64WithTruncation(value);

        public static unsafe void _mm_stream_si64(long* address, long value) => System.Runtime.Intrinsics.X86.Sse2.X64.StoreNonTemporal(address, value);

        public static unsafe void _mm_stream_si64(ulong* address, ulong value) => System.Runtime.Intrinsics.X86.Sse2.X64.StoreNonTemporal(address, value);

        public static Vector128<float> _mm_addsub_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse3.AddSubtract(left, right);

        public static Vector128<double> _mm_addsub_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse3.AddSubtract(left, right);

        public static Vector128<float> _mm_hadd_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalAdd(left, right);

        public static Vector128<double> _mm_hadd_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalAdd(left, right);

        public static Vector128<float> _mm_hsub_ps(Vector128<float> left, Vector128<float> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalSubtract(left, right);

        public static Vector128<double> _mm_hsub_pd(Vector128<double> left, Vector128<double> right) => System.Runtime.Intrinsics.X86.Sse3.HorizontalSubtract(left, right);

        public static unsafe Vector128<double> _mm_loaddup_pd(double* address) => System.Runtime.Intrinsics.X86.Sse3.LoadAndDuplicateToVector128(address);

        public static unsafe Vector128<sbyte> _mm_lddqu_si128(sbyte* address) => System.Runtime.Intrinsics.X86.Sse3.LoadDquVector128(address);

        public static Vector128<double> _mm_movedup_pd(Vector128<double> source) => System.Runtime.Intrinsics.X86.Sse3.MoveAndDuplicate(source);

        public static Vector128<float> _mm_movehdup_ps(Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse3.MoveHighAndDuplicate(source);

        public static Vector128<float> _mm_moveldup_ps(Vector128<float> source) => System.Runtime.Intrinsics.X86.Sse3.MoveLowAndDuplicate(source);

        public static Vector128<short> _mm_blend_epi16(Vector128<short> left, Vector128<short> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<ushort> _mm_blend_epi16(Vector128<ushort> left, Vector128<ushort> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<float> _mm_blend_ps(Vector128<float> left, Vector128<float> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<double> _mm_blend_pd(Vector128<double> left, Vector128<double> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.Blend(left, right, control);

        public static Vector128<sbyte> _mm_blendv_epi8(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<byte> _mm_blendv_epi8(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<short> _mm_blendv_epi8(Vector128<short> left, Vector128<short> right, Vector128<short> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<ushort> _mm_blendv_epi8(Vector128<ushort> left, Vector128<ushort> right, Vector128<ushort> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<int> _mm_blendv_epi8(Vector128<int> left, Vector128<int> right, Vector128<int> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<uint> _mm_blendv_epi8(Vector128<uint> left, Vector128<uint> right, Vector128<uint> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<long> _mm_blendv_epi8(Vector128<long> left, Vector128<long> right, Vector128<long> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<ulong> _mm_blendv_epi8(Vector128<ulong> left, Vector128<ulong> right, Vector128<ulong> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<float> _mm_blendv_ps(Vector128<float> left, Vector128<float> right, Vector128<float> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<double> _mm_blendv_pd(Vector128<double> left, Vector128<double> right, Vector128<double> mask) => System.Runtime.Intrinsics.X86.Sse41.BlendVariable(left, right, mask);

        public static Vector128<float> _mm_ceil_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.Ceiling(value);

        public static Vector128<double> _mm_ceil_pd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.Ceiling(value);

        public static Vector128<double> _mm_ceil_sd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(value);

        public static Vector128<float> _mm_ceil_ss(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(value);

        public static Vector128<double> _mm_ceil_sd(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(upper, value);

        public static Vector128<float> _mm_ceil_ss(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.CeilingScalar(upper, value);

        public static Vector128<long> _mm_cmpeq_epi64(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse41.CompareEqual(left, right);

        public static Vector128<ulong> _mm_cmpeq_epi64(Vector128<ulong> left, Vector128<ulong> right) => System.Runtime.Intrinsics.X86.Sse41.CompareEqual(left, right);

        public static Vector128<short> _mm_cvtepi8_epi16(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int16(value);

        public static Vector128<short> _mm_cvtepu8_epi16(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int16(value);

        public static Vector128<int> _mm_cvtepi8_epi32(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtepu8_epi32(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtepi16_epi32(Vector128<short> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<int> _mm_cvtepu16_epi32(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int32(value);

        public static Vector128<long> _mm_cvtepi8_epi64(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepu8_epi64(Vector128<byte> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepi16_epi64(Vector128<short> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepu16_epi64(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepi32_epi64(Vector128<int> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<long> _mm_cvtepu32_epi64(Vector128<uint> value) => System.Runtime.Intrinsics.X86.Sse41.ConvertToVector128Int64(value);

        public static Vector128<float> _mm_dp_ps(Vector128<float> left, Vector128<float> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.DotProduct(left, right, control);

        public static Vector128<double> _mm_dp_pd(Vector128<double> left, Vector128<double> right, byte control) => System.Runtime.Intrinsics.X86.Sse41.DotProduct(left, right, control);

        public static byte _mm_extract_epi8(Vector128<byte> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static int _mm_extract_epi32(Vector128<int> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static uint _mm_extract_epi32(Vector128<uint> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static float _mm_extract_ps(Vector128<float> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.Extract(value, index);

        public static Vector128<float> _mm_floor_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.Floor(value);

        public static Vector128<double> _mm_floor_pd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.Floor(value);

        public static Vector128<double> _mm_floor_sd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(value);

        public static Vector128<float> _mm_floor_ss(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(value);

        public static Vector128<double> _mm_floor_sd(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(upper, value);

        public static Vector128<float> _mm_floor_ss(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.FloorScalar(upper, value);

        public static Vector128<sbyte> _mm_insert_epi8(Vector128<sbyte> value, sbyte data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<byte> _mm_insert_epi8(Vector128<byte> value, byte data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<int> _mm_insert_epi32(Vector128<int> value, int data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<uint> _mm_insert_epi32(Vector128<uint> value, uint data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<float> _mm_insert_ps(Vector128<float> value, Vector128<float> data, byte index) => System.Runtime.Intrinsics.X86.Sse41.Insert(value, data, index);

        public static Vector128<sbyte> _mm_max_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<ushort> _mm_max_epu16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<int> _mm_max_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<uint> _mm_max_epu32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse41.Max(left, right);

        public static Vector128<sbyte> _mm_min_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<ushort> _mm_min_epu16(Vector128<ushort> left, Vector128<ushort> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<int> _mm_min_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<uint> _mm_min_epu32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse41.Min(left, right);

        public static Vector128<ushort> _mm_minpos_epu16(Vector128<ushort> value) => System.Runtime.Intrinsics.X86.Sse41.MinHorizontal(value);

        public static Vector128<ushort> _mm_mpsadbw_epu8(Vector128<byte> left, Vector128<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Sse41.MultipleSumAbsoluteDifferences(left, right, mask);

        public static Vector128<long> _mm_mul_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.Multiply(left, right);

        public static Vector128<int> _mm_mullo_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.MultiplyLow(left, right);

        public static Vector128<uint> _mm_mullo_epi32(Vector128<uint> left, Vector128<uint> right) => System.Runtime.Intrinsics.X86.Sse41.MultiplyLow(left, right);

        public static Vector128<ushort> _mm_packus_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Sse41.PackUnsignedSaturate(left, right);

        public static Vector128<float> _mm_round_ps(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestInteger(value);

        public static Vector128<float> _MM_FROUND_TO_NEG_INF(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinity(value);

        public static Vector128<float> _MM_FROUND_TO_POS_INF(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinity(value);

        public static Vector128<float> _MM_FROUND_TO_ZERO(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZero(value);

        public static Vector128<float> _MM_FROUND_CUR_DIRECTION(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirection(value);

        public static Vector128<double> _mm_round_pd(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestInteger(value);

        public static Vector128<double> _MM_FROUND_TO_NEG_INF(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinity(value);

        public static Vector128<double> _MM_FROUND_TO_POS_INF(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinity(value);

        public static Vector128<double> _MM_FROUND_TO_ZERO(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZero(value);

        public static Vector128<double> _MM_FROUND_CUR_DIRECTION(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirection(value);

        public static Vector128<double> _mm_round_sd_CurrentDirectionScalar(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(value);

        public static Vector128<double> _mm_round_sd_ToNearestIntegerScalar(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(value);

        public static Vector128<double> _mm_round_sd_ToNegativeInfinityScalar(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(value);

        public static Vector128<double> _mm_round_sd_ToPositiveInfinityScalar(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(value);

        public static Vector128<double> _mm_round_sd_ToZeroScalar(Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(value);

        public static Vector128<double> _mm_round_sd_CurrentDirectionScalar(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(upper, value);

        public static Vector128<double> _mm_round_sd_ToNearestIntegerScalar(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(upper, value);

        public static Vector128<double> _mm_round_sd_ToNegativeInfinityScalar(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(upper, value);

        public static Vector128<double> _mm_round_sd_ToPositiveInfinityScalar(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(upper, value);

        public static Vector128<double> _mm_round_sd_ToZeroScalar(Vector128<double> upper, Vector128<double> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(upper, value);

        public static Vector128<float> _mm_round_ss_CurrentDirectionScalar(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(value);

        public static Vector128<float> _mm_round_ss_ToNearestIntegerScalar(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(value);

        public static Vector128<float> _mm_round_ss_ToNegativeInfinityScalar(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(value);

        public static Vector128<float> _mm_round_ss_ToPositiveInfinityScalar(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(value);

        public static Vector128<float> _mm_round_ss_ToZeroScalar(Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(value);

        public static Vector128<float> _mm_round_ss_CurrentDirectionScalar(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundCurrentDirectionScalar(upper, value);

        public static Vector128<float> _mm_round_ss_ToNearestIntegerScalar(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNearestIntegerScalar(upper, value);

        public static Vector128<float> _mm_round_ss_ToNegativeInfinityScalar(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToNegativeInfinityScalar(upper, value);

        public static Vector128<float> _mm_round_ss_ToPositiveInfinityScalar(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToPositiveInfinityScalar(upper, value);

        public static Vector128<float> _mm_round_ss_ToZeroScalar(Vector128<float> upper, Vector128<float> value) => System.Runtime.Intrinsics.X86.Sse41.RoundToZeroScalar(upper, value);

        public static unsafe Vector128<sbyte> _mm_stream_load_si128(sbyte* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<byte> _mm_stream_load_si128(byte* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<short> _mm_stream_load_si128(short* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<ushort> _mm_stream_load_si128(ushort* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<int> _mm_stream_load_si128(int* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<uint> _mm_stream_load_si128(uint* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<long> _mm_stream_load_si128(long* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static unsafe Vector128<ulong> _mm_stream_load_si128(ulong* address) => System.Runtime.Intrinsics.X86.Sse41.LoadAlignedVector128NonTemporal(address);

        public static bool _mm_testc_si128(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.TestC(left, right);

        public static bool _mm_testnzc_si128(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.TestNotZAndNotC(left, right);

        public static bool _mm_testz_si128(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Sse41.TestZ(left, right);

        public static long _mm_extract_epi64(Vector128<long> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Extract(value, index);

        public static ulong _mm_extract_epi64(Vector128<ulong> value, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Extract(value, index);

        public static Vector128<long> _mm_insert_epi64(Vector128<long> value, long data, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Insert(value, data, index);

        public static Vector128<ulong> _mm_insert_epi64(Vector128<ulong> value, ulong data, byte index) => System.Runtime.Intrinsics.X86.Sse41.X64.Insert(value, data, index);

        public static Vector128<long> _mm_cmpgt_epi64(Vector128<long> left, Vector128<long> right) => System.Runtime.Intrinsics.X86.Sse42.CompareGreaterThan(left, right);

        public static uint _mm_crc32_u8(uint crc, byte data) => System.Runtime.Intrinsics.X86.Sse42.Crc32(crc, data);

        public static uint _mm_crc32_u16(uint crc, ushort data) => System.Runtime.Intrinsics.X86.Sse42.Crc32(crc, data);

        public static uint _mm_crc32_u32(uint crc, uint data) => System.Runtime.Intrinsics.X86.Sse42.Crc32(crc, data);

        public static ulong _mm_crc32_u64(ulong crc, ulong data) => System.Runtime.Intrinsics.X86.Sse42.X64.Crc32(crc, data);

        public static Vector128<byte> _mm_abs_epi8(Vector128<sbyte> value) => System.Runtime.Intrinsics.X86.Ssse3.Abs(value);

        public static Vector128<ushort> _mm_abs_epi16(Vector128<short> value) => System.Runtime.Intrinsics.X86.Ssse3.Abs(value);

        public static Vector128<uint> _mm_abs_epi32(Vector128<int> value) => System.Runtime.Intrinsics.X86.Ssse3.Abs(value);

        public static Vector128<sbyte> _mm_alignr_epi8(Vector128<sbyte> left, Vector128<sbyte> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<byte> _mm_alignr_epi8(Vector128<byte> left, Vector128<byte> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<short> _mm_alignr_epi8(Vector128<short> left, Vector128<short> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<ushort> _mm_alignr_epi8(Vector128<ushort> left, Vector128<ushort> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<int> _mm_alignr_epi8(Vector128<int> left, Vector128<int> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<uint> _mm_alignr_epi8(Vector128<uint> left, Vector128<uint> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<long> _mm_alignr_epi8(Vector128<long> left, Vector128<long> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<ulong> _mm_alignr_epi8(Vector128<ulong> left, Vector128<ulong> right, byte mask) => System.Runtime.Intrinsics.X86.Ssse3.AlignRight(left, right, mask);

        public static Vector128<short> _mm_hadd_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAdd(left, right);

        public static Vector128<int> _mm_hadd_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAdd(left, right);

        public static Vector128<short> _mm_hadds_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalAddSaturate(left, right);

        public static Vector128<short> _mm_hsub_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtract(left, right);

        public static Vector128<int> _mm_hsub_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtract(left, right);

        public static Vector128<short> _mm_hsubs_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.HorizontalSubtractSaturate(left, right);

        public static Vector128<short> _mm_maddubs_epi16(Vector128<byte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Ssse3.MultiplyAddAdjacent(left, right);

        public static Vector128<short> _mm_mulhrs_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.MultiplyHighRoundScale(left, right);

        public static Vector128<sbyte> _mm_shuffle_epi8(Vector128<sbyte> value, Vector128<sbyte> mask) => System.Runtime.Intrinsics.X86.Ssse3.Shuffle(value, mask);

        public static Vector128<byte> _mm_shuffle_epi8(Vector128<byte> value, Vector128<byte> mask) => System.Runtime.Intrinsics.X86.Ssse3.Shuffle(value, mask);

        public static Vector128<sbyte> _mm_sign_epi8(Vector128<sbyte> left, Vector128<sbyte> right) => System.Runtime.Intrinsics.X86.Ssse3.Sign(left, right);

        public static Vector128<short> _mm_sign_epi16(Vector128<short> left, Vector128<short> right) => System.Runtime.Intrinsics.X86.Ssse3.Sign(left, right);

        public static Vector128<int> _mm_sign_epi32(Vector128<int> left, Vector128<int> right) => System.Runtime.Intrinsics.X86.Ssse3.Sign(left, right);

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore CS3021 // Type or member does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute
    }
}
