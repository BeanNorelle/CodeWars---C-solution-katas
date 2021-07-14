using System;
using System.Linq;
using System.Diagnostics;

namespace _140_CountDivisors
{
    class Program
    {   
        private static Stopwatch sw;
        static void Main(string[] args)
        {
            int n = 4000000; 

            double sTime = 0; double fTime = 0; 
            double dtime = 0;

            double d2time = 0;

            sw = new Stopwatch(); int max = 0;
            sw.Start();

            while(max!=10){
            sTime = sw.Elapsed.TotalMilliseconds;
            Divisors(n);
            fTime = sw.Elapsed.TotalMilliseconds;
            dtime = fTime-sTime;
               
            sTime = sw.Elapsed.TotalMilliseconds;
            Linq(n);
            fTime = sw.Elapsed.TotalMilliseconds;
            d2time +=fTime - sTime;
            max++;
         
            }
            sw.Stop();
          Console.WriteLine(string.Format("{0:0.##}",dtime/max));
            Console.WriteLine(string.Format("{0:0.##}",d2time/max));

        }

         public static int Divisors(int n)
        {
            int count = 2;
            for(int i = 2;i<n;i++)
            {
                if(n%i==0) count++; 
            }

            return count;
        }

        public static int Linq(int n)
        {
           int ns =  Enumerable.Range(1,n)
                               .Where(x=>n%x==0)
                               .Count();
            return ns;
        }
    }
}
