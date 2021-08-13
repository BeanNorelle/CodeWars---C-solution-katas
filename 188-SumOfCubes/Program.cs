using System;
using System.Linq;

namespace _188_SumOfCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumCubes(10));
        }

        public static long SumCubes(int n)
        {
            long result = Enumerable.Range(1,n).Select(x=>(long)x*x*x).Sum();

            return result;
        }
    }
}
