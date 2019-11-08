using System;
using System.Runtime.Intrinsics;
using static Fast.Intrinsics;

namespace IntrinsicsPrototyping
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            avx_xorshift128plus_key_t mykey;
            avx_xorshift128plus_init(324, 4444, &mykey);

            var distr = new uint[uint.MaxValue / 100000000+1];
            var answer = new uint[1024*4];
            fixed (uint* pA = answer)
            {
                for (int i = 0; i < 10000; i++)
                {
                    populateRandom_avx_xorshift128plus(&mykey, pA, 1024*4);
                    for (int j = 0; j < 1024*4; j++)
                    {
                        distr[answer[j] / 100000000]++;
                    }
                }
            }
        }

        static void populateRandom_avx_xorshift128plus(avx_xorshift128plus_key_t* mykey,uint* answer, uint size)
        {
            uint i = 0;
            
            const uint blockSize = 8;
            while (i + blockSize <= size)
            {
                _mm256_storeu_si256(answer + i, avx_xorshift128plus(mykey).AsUInt32());
                i += blockSize;
            }
            if (i != size)
            {
                var buffer = new uint[blockSize];
                fixed (uint* pBuffer = buffer)
                {
                    _mm256_storeu_si256(pBuffer, avx_xorshift128plus(mykey).AsUInt32());
                    Buffer.MemoryCopy(answer + i, pBuffer, sizeof(uint) * (size - i), size - i);
                }
            }
        }

        struct avx_xorshift128plus_key_t
        {
            public Vector256<ulong> part1;
            public Vector256<ulong> part2;
        }

        static void xorshift128plus_onkeys(ulong* ps0, ulong* ps1)
        {
            ulong s1 = *ps0;
            ulong s0 = *ps1;
            *ps0 = s0;
            s1 ^= s1 << 23; // a
            *ps1 = s1 ^ s0 ^ (s1 >> 18) ^ (s0 >> 5); // b, c
        }

        static void xorshift128plus_jump_onkeys(ulong in1, ulong in2, ref ulong output1, ref ulong output2)
        {
            var JUMP = new[] { 0x8a5cd789635d2dffUL, 0x121fd2155c472f96UL };
            ulong s0 = 0;
            ulong s1 = 0;
            for (uint i = 0; i < 2; i++)
                for (int b = 0; b < 64; b++)
                {
                    if ((JUMP[i] & 1UL << b) != 0)
                    {
                        s0 ^= in1;
                        s1 ^= in2;
                    }
                    xorshift128plus_onkeys(&in1, &in2);
                }
            output1 = s0;
            output2 = s1;
        }

        static void avx_xorshift128plus_init(ulong key1, ulong key2,
                  avx_xorshift128plus_key_t* key)
        {
            var S0 = new ulong[4];
            var S1 = new ulong[4];
            S0[0] = key1;
            S1[0] = key2;
            xorshift128plus_jump_onkeys(S0[0], S1[0], ref S0[1], ref S1[1]);
            xorshift128plus_jump_onkeys(S0[1], S1[1], ref S0[2], ref S1[2]);
            xorshift128plus_jump_onkeys(S0[2], S1[2], ref S0[3], ref S1[3]);

            fixed (ulong* p0 = S0)
                key->part1 = _mm256_loadu_si256(p0);
            fixed (ulong* p1 = S1)
                key->part2 = _mm256_loadu_si256(p1);
        }

        static Vector256<ulong> avx_xorshift128plus(avx_xorshift128plus_key_t* key)
        {
            Vector256<ulong> s1 = key->part1;
            Vector256<ulong> s0 = key->part2;
            key->part1 = key->part2;
            s1 = _mm256_xor_si256(key->part2, _mm256_slli_epi64(key->part2, 23));
            key->part2 = _mm256_xor_si256(
                _mm256_xor_si256(_mm256_xor_si256(s1, s0),
                    _mm256_srli_epi64(s1, 18)), _mm256_srli_epi64(s0, 5));
            return _mm256_add_epi64(key->part2, s0);
        }


        /*struct pcg32_random_t
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
        }*/
    }
}
