using System;
using System.Collections.Generic;
namespace _109_HammingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(hamming(1));
             Console.WriteLine(hamming(2));
              Console.WriteLine(hamming(3));
               Console.WriteLine(hamming(87));
        }

        public static long hamming(int n)
        {
            long[] ham = new long[n];

            ham[0] = 1;
            int i = 0, j = 0, k = 0;
            long two = 2, three = 3, five = 5;
            

            for (int index = 1; index < n; index++)
            {
                ham[index] = Math.Min(two, Math.Min(three, five));

                if (ham[index] == two)
                    two = 2 * ham[++i];
                if (ham[index] == three)
                    three = 3 * ham[++j];
                if (ham[index] == five)
                    five = 5 * ham[++k]; 
            }

      return ham[n - 1];
        }
    }
}
