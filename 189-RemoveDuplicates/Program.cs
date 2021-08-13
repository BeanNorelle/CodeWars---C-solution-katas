using System;
using System.Linq;

namespace _189_RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string str = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
             Console.WriteLine(RemoveDuplicateWords(str));
        }

        public static string RemoveDuplicateWords(string s)
        {
           return string.Join(" ",s.Split(' ').Distinct());
        }
    }
}
