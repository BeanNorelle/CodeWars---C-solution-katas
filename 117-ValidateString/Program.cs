using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _117_ValidateString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "code";
            string [] dictionary = {"hello","Hello","World","CodeWars"};
            Console.WriteLine(ValidateWord(dictionary,word));
        }

        public static bool ValidateWord(string[] dictionary, string word)
        {
            int strLength = word.Length;
            int dictionarySize = dictionary.Length;

            if (word == string.Empty)  return true;
            
                    for (int i = 0;i<dictionarySize;i++){
                        string terms = dictionary[i];

                        if(word.StartsWith(terms))
                        {   
                              if (ValidateWord(dictionary, word.Substring(terms.Length, word.Length - terms.Length)))
                              return true;
                        }
                    }                 
                    return false;
        }
    }
}
