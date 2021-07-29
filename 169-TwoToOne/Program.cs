using System;
using System.Linq;

namespace _169_TwoToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Longest (string s1, string s2) 
        {
                string Sorted1 = SortString(s1);
                string Sorted2 = SortString(s2);

                return (Sorted1.Length>Sorted2.Length) ? Sorted1 : Sorted2;
        }

        public static string SortString(string a)
        {
          return  string.Concat(a.ToCharArray().Distinct().OrderBy(x=>x));
        }
    }
}
