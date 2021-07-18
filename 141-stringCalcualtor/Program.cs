using System;

namespace _141_stringCalcualtor
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "10";

            Console.WriteLine(Calculate(n,n));
        }

          public static int Calculate(string num1, string num2)
        {
            int nums1 = Convert.ToInt32(num1,2);
            int nums2 = Convert.ToInt32(num2,2);

            return nums1+nums2;
        }
    }
}
