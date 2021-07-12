using System;
using System.Linq;

namespace _135_KillTheKthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KillTheBit(37,3));
        }

        public static int KillTheBit(int n, int k)
        {
         return n & ~(1 << k - 1);
        }
    }
}
