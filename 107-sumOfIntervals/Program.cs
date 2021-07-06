using System;
using System.Linq;
using System.Collections.Generic;

namespace _107_sumOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            (int,int)[] intervals = {(1,4),(7,10),(3,5)}; 

            Console.WriteLine("the total number of intervals is: {0}", SumIntervals(intervals));
        }
         public static int SumIntervals((int, int)[] intervals)
            {
                List<int> intervalIterate =new List<int>();

                foreach(var interval in intervals){
                    for(int i  = interval.Item1+1; i<=interval.Item2;i++){
                            intervalIterate.Add(i);
                    }
                }
                return intervalIterate.Distinct().Count();
            }
    }
}
