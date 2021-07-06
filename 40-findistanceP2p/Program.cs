using System;
using System.Drawing;
using System.Diagnostics;

namespace _40_findistanceP2p
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p2 = new Point(2,3);
            Point p1 = new Point(1,5);
           Stopwatch sw = new Stopwatch();

            sw.Start();
            Console.WriteLine(p2pDistance(p2,p1));
            sw.Stop();

            Console.WriteLine("Elapsed Time: {0}", sw.Elapsed.TotalMilliseconds);

            
            // sw.Start();
            // Console.WriteLine(addNumbers(2,3));
            // sw.Stop();

            // Console.WriteLine("Elapsed Time: {0}", sw.Elapsed.TotalMilliseconds);
        }
        public static double p2pDistance(Point p1, Point p2){
             var Distance = Math.Sqrt(Math.Pow((p1.X-p2.X),2)+Math.Pow((p1.Y-p2.Y),2));
            return Distance;
        }

        public static int addNumbers(int a,int b)=> a+b;


    }
}
