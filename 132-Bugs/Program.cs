using System;
using System.Collections.Generic;

namespace _132_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyDalmatians(20));
        }

        public static string HowManyDalmatians(int number)
        {
            List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
            string respond = ( number <= 10) ? dogs[0] : number <= 50 ? dogs[1] : number == 101 ? dogs[3] : dogs[2];
          
            return respond;
        }
    }
}
