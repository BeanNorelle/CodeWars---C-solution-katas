using System;
using System.Numerics;

namespace _178_PerimterOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(perimeter(5));
        }

        public static BigInteger perimeter(BigInteger n) 
        {
            BigInteger result = 0;
            int curr = 1;
            int prev = 0;
            int next = 0;

            for(int i = 0; i<n;i++)
            {   
                prev = curr;
                curr = next;
                next = curr+prev;

                result += next;
            }

            return result * 4;
        }
    }
}
