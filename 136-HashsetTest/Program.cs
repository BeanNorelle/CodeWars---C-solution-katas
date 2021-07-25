using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _08_ArrayCheck 
{
    class Program
    {


        static List<double> HashTest = new List<double>();
        static List<double> LinqTest = new List<double>();
        static List<double> LinearTest = new List<double>();
        static void Main(string[] args)
        {   
            int [] arr = {1,10,100,1000,10000,100000,1000000,10000000};
            Console.Write("Test Ranges  |  ");
            foreach(int element in arr)
            {
                Console.Write(""+element+"\t|");
            }

            foreach(var range in arr)
            {
                tester(range);
            }
            Console.Write("\nHash Test    |");
            foreach(double s in HashTest)
            {
                Console.Write(" "+string.Format("{0:0.##}",s)+" \t|");
            }
            Console.Write("\nLinq Test    |");
             foreach(double s in LinqTest)
            {
                Console.Write(" "+string.Format("{0:0.##}",s)+" \t|");
            }
            Console.Write("\nLinear Test  |");
             foreach(double s in LinearTest)
            {
                Console.Write(" "+string.Format("{0:0.##}",s)+" \t|");
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



            sw.Start();
            int max = 10;
            for(int i =0;i<max;i++)
            {
            sTime = sw.Elapsed.TotalMilliseconds;
            Hashset(a,r);
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
                HashTest.Add(dTime/max);
                LinqTest.Add(d2Time/max);
                LinearTest.Add(d3Time/max);

                // Console.Write("\t {0}",string.Format("{0:0.##}",(dTime/max)),range);
                // Console.Write("\t {0}",string.Format("{0:0.##}",(d2Time/max)),range);
                // Console.Write("\t {0}", string.Format("{0:0.##}",(d3Time/max)),range);

            sw.Stop();   
        }
        public static bool Hashset(int [] a, int x)
        // isn't hashset supposed to be'faster code  performance wise
        {
            HashSet<int> hashSearch = new HashSet<int>(a);
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