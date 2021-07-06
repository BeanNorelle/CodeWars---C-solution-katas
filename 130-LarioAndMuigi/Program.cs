using System;
using System.Collections.Generic;
using System.Linq;

namespace _130_LarioAndMuigi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

          public static List<int> PipeFix(List<int> numbers)
        {
           numbers.Sort();
           List<int> str = new List<int>();
           int low = numbers[0];
           int high = numbers[numbers.Count-1];

           for(int i = low; i< high; i++)
           {
               str.Add(i);
           }

        return str;
        }
    }
}
