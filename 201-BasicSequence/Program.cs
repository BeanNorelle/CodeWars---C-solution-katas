using System;
using System.Collections.Generic;
using System.Linq;

namespace _201_BasicSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfN(0).ToList().ForEach(x => Console.WriteLine(x));
        }
        public static int[] SumOfN(int n)
        {   
            bool negative = (n<0);
            int max = Math.Abs(n);
            int sum = 0;
            int [] arr = new int[max+1];
            for(int i = 1; i<=max+1 ; i++)
            {     
                arr[i-1] = (negative) ? sum * -1 : sum;
                sum += i;
            }
            return arr;
        }
    }
}
