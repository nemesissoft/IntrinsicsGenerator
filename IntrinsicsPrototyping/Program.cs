using System;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using static Fast.Intrinsics;

namespace IntrinsicsPrototyping
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        struct pcg32_random_t
        {
            public ulong state;
            public ulong inc;
        }
        static uint pcg32_random_r(pcg32_random_t* rng)
        {
            ulong oldstate = rng->state;
            rng->state = oldstate * 6364136223846793005UL + rng->inc;
            ulong xorshifted = ((oldstate >> 18) ^ oldstate) >> 27;
            int rot = (int)(oldstate >> 59);
            return (uint)((xorshifted >> rot) | (xorshifted << ((-rot) & 31)));
        }

        struct avx_xorshift128plus_key_t
        {
            public Vector256<uint> part1;
            public Vector256<uint> part2;
        }
        //https://github.com/lemire/SIMDxorshift/blob/master/src/simdxorshift128plus.c
        Vector256<uint> avx_xorshift128plus(avx_xorshift128plus_key_t* key)
        {
            Vector256<uint> s1 = key->part1;
            Vector256<uint> s0 = key->part2;
            key->part1 = key->part2;
            s1 = _mm256_xor_si256(key->part2, _mm256_slli_epi32(key->part2, 23));
            key->part2 = _mm256_xor_si256(
                _mm256_xor_si256(_mm256_xor_si256(s1, s0),
                    _mm256_srli_epi32(s1, 18)), _mm256_srli_epi32(s0, 5));
            return _mm256_add_epi32(key->part2, s0);
        }
    }
}
