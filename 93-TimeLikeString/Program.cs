using System;

namespace _93_TimeLikeString
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 10200;
            string str = n.ToString();
           string name =  (str.Length==4)? str.Insert(2, ":"): (str.Length<=3)? str.Insert(1, ":") : throw new ArgumentException("hour is out of range!");

           Console.WriteLine(name);
        }
    }
}
