using System;
using System.Collections.Generic;
using System.Linq;

namespace _99_arrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a ={1,2,3,3,3};
            int []b = {1,2};
            foreach(var s in ArrayDiff(a,b))
            Console.Write(s);
        }
          public static int[] ArrayDiff(int[] a, int[] b)
         {                        

                var aList= new List<int>();
                var bList = new HashSet<int>(b);
                foreach(var s in a)
                {
                if(!bList.Contains(s))
                   aList.Add(s);
                }
               
                return aList.ToArray();
            
           }
        }
    }

