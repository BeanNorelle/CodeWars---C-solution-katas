using System;

namespace _193_AlternateCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToAlternatingCase("helloWorld!"));
        }

        public static string ToAlternatingCase (string s)
        {   
            string sb = string.Empty;
            foreach(char ch in s)
            {
                sb += (Char.IsLetter(ch)) ?  (Char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)) : ch;
            }

            return sb;
        }
    }
}
