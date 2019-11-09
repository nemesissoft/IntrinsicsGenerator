using System;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static Fast.Intrinsics;

namespace IntrinsicsPrototyping
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            XorShiftState mykey = XorShiftState.NewState(324, 4444);


            var distr = new uint[uint.MaxValue / 100000000 + 1];
            var answer = new uint[1024 * 4];
            fixed (uint* pA = answer)
            {
                for (int i = 0; i < 1; i++)
                {
                    PopulateArray(&mykey, pA, 1024 * 4);
                    /*for (int j = 0; j < 1024 * 4; j++)
                    {
                        distr[answer[j] / 100000000]++;
                    }*/
                }
            }

            var tt = string.Join(",", answer.Take(40));
            bool b = CalculateMD5Hash(tt) == "9BA4E243FD5D9854E727A56475F92A5F";

            static string CalculateMD5Hash(string input)
            {
                // step 1, calculate MD5 hash from input
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);

                // step 2, convert byte array to hex string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        static void PopulateArray(XorShiftState* mykey, uint* answer, uint size)
        {
            uint i = 0;

            const uint blockSize = 8;
            while (i + blockSize <= size)
            {
                _mm256_storeu_si256(answer + i, Next(mykey).AsUInt32());
                i += blockSize;
            }
            if (i != size)
            {
                var buffer = new uint[blockSize];
                fixed (uint* pBuffer = buffer)
                {
                    _mm256_storeu_si256(pBuffer, Next(mykey).AsUInt32());
                    Buffer.MemoryCopy(answer + i, pBuffer, sizeof(uint) * (size - i), size - i);
                }
            }
        }

        public class SimdXorShiftRandom
        {

        }
        public struct XorShiftState
        {
            public Vector256<ulong> Hi { get; set; }

            public XorShiftState(Vector256<ulong> lo, Vector256<ulong> hi) => Hi = hi;

            private static void ShiftKeys(ulong in1, ulong in2, out ulong output1, out ulong output2)
            {
                static void SwitchKeys(ref ulong key1, ref ulong key2)
                {
                    ulong k1 = key1;
                    ulong k2 = key2;
                    key1 = k2;
                    k1 ^= k1 << 23; // a
                    key2 = k1 ^ k2 ^ (k1 >> 18) ^ (k2 >> 5); // b, c
                }

                Span<ulong> jump = stackalloc ulong[] { 0x8a5cd789635d2dffUL, 0x121fd2155c472f96UL };
                ulong s0 = 0;
                ulong s1 = 0;
                for (int i = 0; i < 2; i++)
                    for (int b = 0; b < 64; b++)
                    {
                        if ((jump[i] & 1UL << b) != 0)
                        {
                            s0 ^= in1;
                            s1 ^= in2;
                        }
                        SwitchKeys(ref in1, ref in2);
                    }
                output1 = s0;
                output2 = s1;
            }

            public static XorShiftState NewState(ulong seed1, ulong seed2)
            {
                Span<ulong> s0 = stackalloc ulong[4];
                Span<ulong> s1 = stackalloc ulong[4];
                s0[0] = seed1;
                s1[0] = seed2;
                ShiftKeys(s0[0], s1[0], out s0[1], out s1[1]);
                ShiftKeys(s0[1], s1[1], out s0[2], out s1[2]);
                ShiftKeys(s0[2], s1[2], out s0[3], out s1[3]);

                fixed (ulong* p0 = s0)
                fixed (ulong* p1 = s1)
                    return new XorShiftState(Avx.LoadVector256(p0), Avx.LoadVector256(p1));
            }
        }
        
        public static Vector256<ulong> Next(XorShiftState* key)
        {
            Vector256<ulong> oldHi = key->Hi;
            
            Vector256<ulong> xorShift = Avx2.Xor(oldHi, Avx2.ShiftLeftLogical(oldHi, 23));
            
            var newHi = Avx2.Xor(
                Avx2.Xor(Avx2.Xor(xorShift, oldHi),
                    Avx2.ShiftRightLogical(xorShift, 18)), Avx2.ShiftRightLogical(oldHi, 5));

            key->Hi = newHi;

            return Avx2.Add(newHi, oldHi);
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
