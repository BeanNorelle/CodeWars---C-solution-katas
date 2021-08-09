using System;
using System.Linq;
using System.Collections.Generic;

namespace _187_Weight4Weight
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine(orderWeight("56 65 74 100 99 68 86 180 90"));
            Console.WriteLine(orderWeight2("56 65 74 100 99 68 86 180 90"));
        }

        public static string orderWeight(string str) 
        {
            return string.Join(" ",str.Split(' ')
                                      .OrderBy(x=>x.Select(a=>(int)Char
                                      .GetNumericValue(a)).Sum())
                                      .ThenBy(y=>y));
        }

        public static string orderWeight2(string str)
        {
            Dictionary<string,int> dictnum = new Dictionary<string,int>();
            List<string> slist = new List<string>(str.Split(' '));
            slist.Sort();
            
            foreach(string c in slist)
            {
                dictnum.Add(c,sum(c));
            }
            
            return string.Join(" ", dictnum.OrderBy(x=>x.Value).Select(y=>y.Key));
        }
        public static int sum(string c)
        {   int sum = 0;
            foreach(char cs in c)
            {
                sum += (int)Char.GetNumericValue(cs);
            }
            return sum;
        }
    }
}
