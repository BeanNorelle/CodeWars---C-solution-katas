using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace _158_CountStrings
{
    class Program
    {
        static void Main(string[] args)
        {   
            Stopwatch sw = new Stopwatch();
            
            string test  = CreateTestStr(100000);
            double ftime = 0;
            double stime = 0;
            double dtime = 0;
            double d2time = 0;
            double d3time = 0;

            int max =0;
            sw.Start();
            while(max!=10){

            stime = sw.Elapsed.TotalMilliseconds;
            Count(test);
            ftime = sw.Elapsed.TotalMilliseconds;
            dtime += ftime - stime;
            
            stime = sw.Elapsed.TotalMilliseconds;
            Count2(test);
            ftime = sw.Elapsed.TotalMilliseconds;
            d2time += ftime - stime;

            stime = sw.Elapsed.TotalMilliseconds;
            Count3(test);
            ftime = sw.Elapsed.TotalMilliseconds;
            d3time += ftime - stime;

            max++;
            }
            sw.Stop();

            Console.WriteLine(string.Format("{0:0.####}",dtime/max));
            Console.WriteLine(string.Format("{0:0.####}",d2time/max));
             Console.WriteLine(string.Format("{0:0.####}",d3time/max));

            // foreach(var s in Count3(test))
            // {
            //     Console.WriteLine(s.Key+" "+s.Value);
            // }
        }
         public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char,int> newDict = new Dictionary<char, int>();
            List<char> chArr = str.ToCharArray().Distinct().ToList();
       
            int arLength = chArr.Count; int count =0;
            for(int i =0;i<arLength;i++)
            {   count = 0;
                for(int j=0;j<str.Length;j++)
                {
                    if(chArr[i]==str[j]) count++;
                }
                newDict.Add(chArr[i],count);
            }
            return newDict;
        }

        public static Dictionary<char,int> Count2(string str)
        {
            return str.GroupBy(x=>x).ToDictionary(x=>x.Key,x=>x.Count());
        }
         public static Dictionary<char, int> Count3(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();   
            int slength = str.Length;
            for(int i =0; i<slength;i++)
            {
            if(dic.ContainsKey(str[i]))
            {
                dic[str[i]] += 1;
            }
            else
            {
                dic.Add(str[i],1);
            }  
            }
            return dic;
        }


        public static string CreateTestStr(int count)
        {
            Random rand = new Random();
            string s = "";
            while(count!=0)
            {
              s+=Convert.ToChar(rand.Next('A','Z'+1));
              count--;
            }

            return s;
        }
    }
}
