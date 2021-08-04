using System;

namespace _172_NameArray
{
    class Program
    {
        static void Main(string[] args)
        {  
            string [] str = {"hello","world","me"};
            foreach(var s in CapMe(str))
            {
                Console.WriteLine(s);
            }
        }

        public static string[] CapMe(string[] strings)
        {
            string [] str = new string [strings.Length];
            int i = 0;
            foreach(var words in strings)
            {
               str[i] =  words.Substring(0,1).ToUpper() + words.Substring(1).ToLower();
               i++;
            }
            return str;
        }
    }
}
