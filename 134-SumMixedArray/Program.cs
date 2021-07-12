using System;
using System.Linq;

namespace _134_SumMixedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            object [] x = {9, 3, "7", "3"};
            Console.WriteLine(SumMix(x));
        }

          public static int SumMix(object[] x)
        {
            return x.Sum(Convert.ToInt32);
        }
    }
}
