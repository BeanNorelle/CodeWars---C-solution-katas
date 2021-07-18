using System;
using System.Text.RegularExpressions;

namespace _144_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigLatin("Hello World !"));
        }

        public static string PigLatin(string str)
        {
          
            string [] strArr = str.Split(' ');
            string [] newArr = new string [strArr.Length];

            for(int i =0;i<strArr.Length;i++)
            {
             if(!strArr[i].Contains("!"))
              newArr[i] = strArr[i].Substring(1)+strArr[i].Substring(0,1)+"ay";
             else
              newArr[i] = strArr[i];
            }

            return string.Join(" ",newArr);
        }
    }
}
