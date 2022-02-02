using System;
using System.Collections.Generic;
using System.Linq;

namespace _205_ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int> {1,2,3,4,5,6,7,8 };

            ReverseList(n).ForEach(x => Console.WriteLine(x)) ;
        }

        public static List<int> ReverseList (List<int> List)
        {
            List<int> r = new List<int>();
           for(int i = List.Count - 1; i >= 0;i--) 
            {
                r.Add(List[i]);
            }

            return r;
        }
    }
}
