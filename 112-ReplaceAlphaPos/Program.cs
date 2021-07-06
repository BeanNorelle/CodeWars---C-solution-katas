using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _112_ReplaceAlphaPos
{
    class Program
    {
        static void Main(string[] args)
        {     
            string text = "Hello World!";
         
            Console.WriteLine(AlphabetPosition(text));

        }
          public static string AlphabetPosition(string text)
        {            
            string str = Regex.Replace(text.ToLower(), @"[^a-z]", "");            
            char [] strCh = str.ToCharArray();

            StringBuilder sB = new StringBuilder();

            for(int i = 0;i<strCh.Length;i++)
            {
                sB.Append((Convert.ToInt32(strCh[i])-96).ToString());
              if(strCh.Length-1!=i)  
                sB.Append(" ");
            }

            return sB.ToString();
        }
    }
}
