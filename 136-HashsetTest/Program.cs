using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _08_ArrayCheck 
{
    class Program
    {
        static void Main(string[] args)
        {   
  
            int [] arr = {5,100,1000,10000,100000,1000000};

            foreach(var range in arr)
            {
                Console.WriteLine("\ntest for range: {0}", range);
                tester(range);
            }
   
        }  
        public static void tester(int range)
        {
            Stopwatch sw = new Stopwatch();
            Random rand = new Random();
            int r = rand.Next(1,range);
            var a = Enumerable.Range(1,range).ToArray();
            double sTime = 0;
            double fTime = 0;

            double s2Time = 0;
            double f2Time = 0;

            double s3Time = 0;
            double f3Time = 0;  
            
            double dTime = 0;
            double d2Time = 0;
            double d3Time = 0.00;

            HashSet<int> hashSearch = new HashSet<int>(a);

            sw.Start();
            int max = 100;
            for(int i =0;i<max;i++)
            {
            sTime = sw.Elapsed.TotalMilliseconds;
            Hashset(hashSearch,r);
            fTime = sw.Elapsed.TotalMilliseconds;
            dTime += fTime - sTime;
   
            s2Time = sw.Elapsed.TotalMilliseconds;
            Linq(a,r);
            f2Time = sw.Elapsed.TotalMilliseconds;
            d2Time += f2Time - s2Time;
 
            s3Time = sw.Elapsed.TotalMilliseconds;
            Foreachloop(a,r);
            f3Time = sw.Elapsed.TotalMilliseconds;
            d3Time += f3Time - s3Time;
            }
                Console.WriteLine("Range is {1}, Hashset test Elapsed time: {0}",string.Format("{0:0.##}",(dTime/max)),range);
                Console.WriteLine("Range is {1}, Linq test Elapsed ime: {0}",string.Format("{0:0.##}",(d2Time/max)),range);
                Console.WriteLine("Range is {1}, Foreach loop test Elapsed time: {0}", string.Format("{0:0.##}",(d3Time/max)),range);

            sw.Stop();   
        }
        public static bool Hashset(HashSet<int> a, int x)
        // isn't hashset supposed to be'faster code  performance wise
        {
            return a.Contains(x);
        }

        public static bool Linq(int[] a, int x)//linq solution
        {
            return a.Contains(x);
        }

        public static bool Foreachloop(int[] a, int x)//foreach loop
        {
            foreach(var s in a)
            {
                if(s==x) return true;
            }
            return false;
        }
    }
}