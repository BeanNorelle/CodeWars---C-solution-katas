using System;
using System.Diagnostics;
using System.Linq;

namespace _210_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Stopwatch sw = new Stopwatch();
            double time2 = 0;
            double time1 = 0;
            var a = Enumerable.Range(1,1000000).Select(c=>c).ToArray();
            string str = String.Join(",",a);
           

            sw.Start();
            time1 = sw.Elapsed.TotalMilliseconds;
            AddQoutes(str);
            time2 = sw.Elapsed.TotalMilliseconds;

            Console.WriteLine(time2 - time1);

            time1 = sw.Elapsed.TotalMilliseconds;
            AddQoutesSplit(str);
            time2 = sw.Elapsed.TotalMilliseconds;

            Console.WriteLine(time2 - time1);
        }

        public static string AddQoutes(string input)//method for replace function
        {
           
           return "\"" + input.Replace(",","\",\"") + "\"";
        }

        public static string AddQoutesSplit(string input)//method for string.split and string.join
        {
             string [] StrArr=  input.Split(',');
           int i = 0;
           foreach(var ListItem in StrArr)
           {         
               StrArr[i] = "\"" +ListItem + "\"";
               i++;
           }
           return string.Join(",", StrArr);
        }
    }
}
