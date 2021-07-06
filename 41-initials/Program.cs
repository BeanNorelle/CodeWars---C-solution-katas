using System;
using System.Linq;

namespace _41_initials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
         public static string AbbrevName(string name)
        {
            return string.Join(".", name.Split().Select(s => s[0])).ToUpper();
        }
    }
}
