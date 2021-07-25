using System;
using System.Collections.Generic;
using System.Linq;

namespace _156_PascalCaseToSnakeCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LinqToUnderScore("HelloWord"));
        }

        public static string ToUnderscore(int str) 
        {
            return Convert.ToString(str);
        }

        public static string ToUnderscore(string str) 
        {
           List<string> sList = new List<string>();
           string word = str[0].ToString();
           
           for(int i =1; i < str.Length; i++)
           {                   
               if(Char.IsUpper(str[i]))
               {          
                   sList.Add(word);
                   word =string.Empty;
               }
               word+=str[i];  
                            if(str.Length-1==i) sList.Add(word);       
           }
           return string.Join("_",sList).ToLower();
        }

        public static string LinqToUnderScore(string str)
        {
           return string.Concat(str.Select(ch=>char.IsUpper(ch) ? "_"+char.ToLower(ch) : ch.ToString()));
        }
    }
}
