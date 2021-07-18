using System;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _147_ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            double sTime = 0;
            double fTime = 0; 

            double d2Time = 0;
            double dTime = 0;

            var s = string.Join(" ",Enumerable.Range(1,10000).Select(x=>"Hello").ToArray());
          

            string n = s;
            int max =1;
            sw.Start();

            while(max!=1000)
            {
            sTime = sw.Elapsed.TotalMilliseconds;
            ReverseWords(n);
            fTime = sw.Elapsed.TotalMilliseconds;
            dTime += fTime - sTime;

            sTime = sw.Elapsed.TotalMilliseconds;
            ReverseWords2(n);
            fTime = sw.Elapsed.TotalMilliseconds;
            d2Time += fTime - sTime;
            max++;
            }
              Console.WriteLine("Linq: "+string.Format("{0:0.##}",dTime/max));
              Console.WriteLine("ForeachBulder "+string.Format("{0:0.##}",d2Time/max));
            sw.Stop();
        }
        public static string ReverseWords(string str)
        {     
            return string.Join(" ",str.Split(' ')
                                      .Select(x=>new string(x
                                      .Reverse()
                                      .ToArray()
                                        )));

        }

        public static string ReverseWords2(string str)
        {
            var splStr = str.Split(" ");
            var builder = new StringBuilder();
            foreach (var s in splStr)
            {
            var charArr = s.ToCharArray();
            for (var i = charArr.Length - 1; i >= 0; i--)
                builder.Append(charArr[i]);
                
            builder.Append(" ");
            }
            
            return builder.ToString().Trim();
        }
    }
}
