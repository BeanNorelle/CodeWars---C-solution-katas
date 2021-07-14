using System;
using System.Linq;
using System.Collections.Generic;

namespace _139_ObserverdPin
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12345";
            foreach(var ss in GetPINs(s))
            {
                Console.WriteLine(ss);
            }

            Console.WriteLine(GetPINs(s).Count);
        }

        public static Dictionary<string,IEnumerable<string>> GetPinApprox = new Dictionary<string, IEnumerable<string>>()
        {
            { "0", new[] { "8", "0" }},
            { "1", new[] {"1","2","4"}},
            { "2", new[] {"1","2","3","5"}},
            { "3", new[] {"2","3","6"}},
            { "4", new[] {"1","4","5","7"}},
            { "5", new[] {"2","4","5","6","8"}},
            { "6", new[] { "3", "5", "6", "9" }},
            { "7", new[] { "4", "7", "8" }},
            { "8", new[] { "5", "7", "8", "9", "0" }},
            { "9", new[] { "6", "8", "9" }}     
        };
        public static List<string> GetPINs(string observed)
        {
              var nlist = new List<string>() { "" };
            foreach (var n in observed)
            {
                nlist = perma(nlist, n);
            }
            return nlist;
        }
        public static List<string> perma(List<string> list, Char n)
        {
            List<string> sList = new List<string>();

            for(int i = 0; i<list.Count();i++)
            {
                int val = (int)char.GetNumericValue(n);
                var sValue = GetPinApprox.ElementAt(val).Value;

                for(int j=0;j<sValue.Count();j++)
                {
                  sList.Add(list.ElementAt(i)+sValue.ElementAt(j));
                }
            }
            return sList;
        }
    }
}
