using System;
using System.Linq;
using System.Collections.Generic;

namespace _54_enumerate
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var s in ReverseSeq(5321)){
                Console.Write(s);
            }
           
        }
         public static long[] ReverseSeq(long n)
            {
                
               return n.ToString().Reverse().Select(t=>Convert.ToInt64(t.ToString())).ToArray();
               
              // .Select(t => Convert.ToInt64(t.ToString())).ToArray();
            }
    }
}
