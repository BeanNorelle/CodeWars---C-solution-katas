using System;
using System.Linq;

namespace _52_linqenumerable
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach(var n in number(3)){
                Console.WriteLine(n);
            }
        }
        public static int[] number(int n){
        return Enumerable.Range(1,n).ToArray();
        }
    }
}
