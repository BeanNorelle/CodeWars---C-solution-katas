using System;

namespace _167_FirstNonRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingLetter("Stress"));
        }
         public static string FirstNonRepeatingLetter(string s)
        {
            char [] CharArray = s.ToCharArray();
            int clength = CharArray.Length;
            int count = 0; string letter = string.Empty;

            for (int i = 0; i < clength; i++)
            {
                letter = CharArray[i].ToString();
                count = 0;
                for(int j = 0; j < clength; j++)
                {
                    if (letter.ToLower() == CharArray[j].ToString().ToLower()) count++;
                }
                if (count == 1) break;
            }
            return letter;
        }
    }
}
