using System;
using System.Linq;

namespace _148_SquaredStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = "abcd\nefgh\nijkl\nmnop";
            Console.WriteLine(VertMirror(s));

            Console.WriteLine(HorMirror(s));


        }

        public  static string VertMirror(string strng)
        {
            string vm = string.Join("\n",strng
                              .Split("\n")
                              .Select(x=>new string(x
                              .Reverse()
                              .ToArray())));

            return vm;
        }
        public  static string HorMirror(string strng)
        {
            string hm = string.Join("\n",strng
                              .Split("\n")
                              .Reverse());

            return hm;
        } 
    }
}
