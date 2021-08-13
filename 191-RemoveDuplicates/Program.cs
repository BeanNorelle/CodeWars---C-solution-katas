using System;
using System.Collections.Generic;
using System.Linq;

namespace _191_RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intarr = new List <int>{1, 5, 2, 0, 2, -3, 1, 10};
            Unique(intarr).ForEach(x=>Console.WriteLine(x));
        }

         public static List<int> Unique(List<int> integers)
        {
           return integers.Distinct().ToList();
        }
    }
}
