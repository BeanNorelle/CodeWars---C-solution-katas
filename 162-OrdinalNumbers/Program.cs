using System;

namespace _162_OrdinalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2122%10);
        }

          public static string Ordinal(int number, bool brief = false)
        {
                      
            if ((number / 10) % 10 == 1) return "th";
            if(number%10==1) return "st";
            if(number%10==2) return brief ? "d" : "nd";
            if(number%10==3) return brief ? "d" : "rd";

            return "th";
        }
    }
}
