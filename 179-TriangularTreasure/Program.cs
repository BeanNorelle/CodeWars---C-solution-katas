using System;
using System.Linq;

namespace _179_TriangularTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DateTime dob = DateTime.Parse("01-September-1990");
             Console.WriteLine(dob.Month);
        }

         public static int Triangular(int n)
        { 
            return Enumerable.Range(1,n).Sum();
        }
    }
}
