using System;
using System.Collections.Generic;
using System.Linq;

namespace _219_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1976097509;
            Console.WriteLine(((PrimeCheck(n-2)||PrimeCheck(n+2))) && PrimeCheck(n));
            
        }

        public static bool PrimeCheck(int nums)
        {
        if (nums <= 1) return false;
        if (nums == 2) return true;
        if (nums % 2 == 0) return false;

        int sqr = (int)Math.Floor(Math.Sqrt(nums));

            for (int i = 3; i <= sqr; i+=2)
                if (nums % i == 0)
                    return false;

            return true;   
        }


    }
}
