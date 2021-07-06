using System;
using System.Linq;

namespace _09_practice
{

    //reverses the given string
    class Program
    {
        static void Main(string[] args)
        {

            String str = "hello world";


            String str2 = string.Join(" ", str.Split(' ').Reverse());
            
            Console.WriteLine(str);
        }
    }
}
