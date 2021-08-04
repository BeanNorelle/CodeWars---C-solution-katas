using System;
using System.Linq;

namespace _175_MaximumLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Mxdiflg(string[] a1, string[] a2) 
        {
            int max = 0; int sum = 0;
            foreach(var a in a1)
            {
                foreach(var b in a2)
                {   
                    sum =  Math.Abs(a.Length-b.Length);
                   if(max<sum) max =sum;
                }
            }
            return max;
        }

          public static int Mxdiflg2(string[] a1, string[] a2)
          {   
              return (a1.Length==0||a2.Length==0) ? -1 : GetMaxDifference(a1,a2);           
          } 

          public static int GetMaxDifference( string[] a1, string[] a2)
          {
              int num1 = Math.Abs(a1.Max(x=>x.Length) - a2.Min(x=>x.Length));
              int num2 = Math.Abs(a1.Min(x=>x.Length) - a2.Max(x=>x.Length));

              return Math.Max(num1,num2);
          }
    }
}
