using System;
using System.Diagnostics;

namespace _104_countDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Console.WriteLine("Number of Divisions should be 6, but is {0}", Divisions(100000,2));
            sw.Stop();
            Console.WriteLine("Elasped time {0}", sw.Elapsed.TotalMilliseconds);

              sw.Start();
            Console.WriteLine("Number of Divisions should be 6, but is {0}", Div2(100000,2));
            sw.Stop();
            Console.WriteLine("Elasped time {0}", sw.Elapsed.TotalMilliseconds);
        }

        public static int Divisions(int n, int divisor)
        {
            bool isZero = false; int count = 0;
            int div = n;

            while(!isZero){  
                
                div = div/divisor;             
                if(div==0) isZero = true;  
                else 
                count++;              
            } 
            
        return count;
        }


        public static int Div2(int n, int divisor)
        {
           return (int)Math.Log(n, divisor);
        }
    }
}
