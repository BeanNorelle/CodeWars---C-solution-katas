using System;
using System.Text.RegularExpressions;

namespace _208_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsDigitFive("ABCDA"));
        }

        public static Boolean IsDigitFive(string input)
        {
            return Regex.IsMatch(input,@"^[A-Z]{5}$"); 
            // ^ will anchor the match to the beginnings and $ will anchor it to the end\
            // [0-9] indicates the character digits in specific ranges from 0-9 
            // {5} is a quantifier indicating to repeat the [0-9] five times
        }
    }

}
