using System;

namespace _102_SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(-3));
        }
        public static int Sum(int n)
        {
            int num = Math.Abs(n);
           char [] numCh =  num.ToString().ToCharArray();
            int sum = 0;
           foreach(var s in numCh)
           {
               sum+= (int)(Char.GetNumericValue(s));
           }

           return sum;
        }
    }
}
