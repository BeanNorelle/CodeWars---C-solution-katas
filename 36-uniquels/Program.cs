using System;
using System.Linq;
using System.Collections.Generic;

namespace _36_uniquels
{
    class Program
    {
        static void Main(string[] args)
        {
            string []ch = {"asd,aa,sda"};
           Console.WriteLine(UniqueInOrder(ch));
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
            {
                   
                    
   
       // string output = new String(input.ToCharArray().Distinct().ToArray());
                    List<T> list = iterable.ToList();
                         list.Distinct();

                return list.AsEnumerable();
            }


        
    }
}
