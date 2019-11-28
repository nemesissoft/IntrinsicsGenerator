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
