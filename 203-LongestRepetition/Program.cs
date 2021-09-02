using System;
using System.Collections.Generic;

namespace _203_LongestRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple <char?,int> LR = LongestRepetition("aaaabb");
            Console.WriteLine(LR.Item1+" "+LR.Item2);
        }

        public static Tuple<char?, int> LongestRepetition(string input)
        {
            return (input==string.Empty) ? new Tuple<char?, int>(null, 0) : getLR(input);
        }

        public static Tuple<char?,int> getLR(string text)
        {
            char rchar = text[0]; int rcount = 1; int currentCount = 0; char previousChar = char.MinValue;
            foreach (char character in text)
            {
                if (character != previousChar)
                {
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }
                if (currentCount > rcount)
                {
                    rchar = character;
                    rcount = currentCount;
                }
                previousChar = character;
            }
                return new Tuple<char?, int>(rchar, rcount);
        }
    }
    
}
