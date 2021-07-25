using System;
using System.Diagnostics;

namespace _154_TwistedSum
{
    class Program
    {
        static void Main(string[] args)
        {  
            Stopwatch sw = new Stopwatch();
            double stime =0; double ftime=0; 
            double dtime =0;
            double d2time =0;     
            int max =0;
            int range = 100000;
            sw.Start();
            while(max<1000)
            {
                stime=sw.Elapsed.TotalMilliseconds;
                Solution2(range);
                ftime=sw.Elapsed.TotalMilliseconds;
                dtime += ftime - stime;

                stime=sw.Elapsed.TotalMilliseconds;
                Solution(range);
                ftime=sw.Elapsed.TotalMilliseconds;
                d2time += ftime - stime;

                max++;
            }  
            
            sw.Stop();

            Console.WriteLine(" "+string.Format("{0:0.##}",dtime/100));
            Console.WriteLine(" "+string.Format("{0:0.##}",d2time/100));
        }
        public static long Solution(long n)
        {   
            string num ="";
            long sum=0;
            for(int i =1;i<=n;i++)
            {
               if(i<10) sum+=i;
               else{
                    num = Convert.ToString(i);
                    for(int j=0;j<num.Length;j++)
                    {
                        sum+=(long)Char.GetNumericValue(num[j]);
                    }              
                }
            }
            return sum;
        }

        public static long Solution2(long n)
        {
            if (n == 0) return 0;
            var r = Solution(n - 1);
            var x = n;
            while (x >= 10)
            {
            r += x % 10;
            x = x / 10;
            }
            r += x;
            return r;
        }
    }
}
