using System;
using System.Linq;
using System.Collections.Generic;

namespace _181_FormatWordsToSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = {"Kevin","Kayn"};
            Console.WriteLine(FormatWords(words));
        }

        public static string FormatWords(string [] wordsArr)
        {
           var words = FilterEmpty(wordsArr);

          if(words.Length==0) return "";
          
          if(words.Length==1) return words[0];

          if(words.Length==2) return words[0] + " and " + words[1];
         

          var s = string.Join(", ", words.SkipLast(1)) + " and " + words.Last();

          return s;
            
        }

        public static string [] FilterEmpty(string[] words)
        {
          List <string> list = new List<string>();
          foreach(string word in words)
          {
              if(word!=string.Empty) list.Add(word);
          }
          return list.ToArray();
        }
    }
}
