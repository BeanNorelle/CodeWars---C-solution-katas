using System;
using System.Collections.Generic;

namespace _185_FindTheDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

         public static int[] Divisors(int n)
        {
            List <int> nlist = new List <int>();
            for(int i = 2; i< n;i++)
            {
                if(n%i==0) nlist.Add(i);
            }
            
            retrun nlist.ToArray();
        }
    }
}
