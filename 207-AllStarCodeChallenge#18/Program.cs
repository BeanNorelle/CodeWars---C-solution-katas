using System;

namespace _207_AllStarCodeChallenge_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrCount("asdasd","a"));
        }

         public static int StrCount(string str, string letter)
        {   
            int count = 0;
            foreach(var ch in str)
            {
                if(Convert.ToString(ch)==letter) count++;
            }

            return count;
        }
    }
}
