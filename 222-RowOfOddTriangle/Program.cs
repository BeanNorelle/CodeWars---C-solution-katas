using System;
using System.Collections.Generic;
using System.Linq;

namespace _222_RowOfOddTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(long s in IsRow(2))
            {
                Console.Write(s+ " ");
            }
        }

        public static long[] IsRow(long n)
        {       
                long s = (long) n;
                long[] nlist = new long[s];
                long counter = 1;

                for(long i = 0; i < s; i++)
                {   
                    nlist[i] = s * (s - 1)+(i + counter);
                         counter++;
                }
                return nlist;
        }
    }
}
