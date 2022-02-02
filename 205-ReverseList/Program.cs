using System;
using System.Collections.Generic;
using System.Linq;

namespace _205_ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> n = new List<int>{1,2,3,4,5,6,8,9};
           ReverseList(n).ForEach(x => Console.WriteLine(x + " "));
        }
         public static List<int> ReverseList(List<int> list)
        {
            list.Reverse();
        
            return list.ToList();
        }
    }
}
