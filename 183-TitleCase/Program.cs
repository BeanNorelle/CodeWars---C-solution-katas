using System;
using System.Collections.Generic;

namespace _183_TitleCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TitleCase("First a of in","an often into"));
        }

         public static string TitleCase(string title, string minorWords="")
        {
            string [] words = FilterWords(title.Split(" "));
            string [] minors = (minorWords.Length==0) ? new string[0] : minorWords.Split(" ");
            string [] sentence = new string [words.Length];

            sentence[0] = (words[0]).Substring(0,1).ToUpper() + words[0].Substring(1).ToLower();
            for(int i =1;i<words.Length;i++)
            {
                sentence[i] = (IsContains(minors,words[i])) 
                ? words[i].ToLower()
                : words[i].Substring(0,1).ToUpper() + words[i].Substring(1).ToLower();                     
            }
            return string.Join(" ",sentence);
        }

        public static string [] FilterWords(string [] words)
        {
            List <string> slist = new List<string>();
            foreach(string word in words)
            {
                if(word!=string.Empty||word!= null) 
                {slist.Add(word);}
            }
            return slist.ToArray();
        } 

        public static bool IsContains(string [] minorWords,string word)
        {  
            foreach(string minW in minorWords)
            {
                if(minW.ToLower()==word.ToLower()) return true;
            }
            return false;
        }

    
    }
}
