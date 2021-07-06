using System;
using System.Collections.Generic;
using System.Linq;

namespace _92_WhereMyAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>{"aabb", "abcd", "bbaa", "dada"};

            foreach(var s in Anagrams("abba",words)){
                Console.WriteLine(s);
            }
        }
          public static List<string> Anagrams(string word, List<string> words)
        {
            char [] wordFrom = word.ToLower().ToCharArray();
            Array.Sort(wordFrom);
            string WordFrom = new string(wordFrom);

            List<string> AnaGrams = new List<string>();

            foreach(var s in words){
               char[] wordTo = s.ToLower().ToCharArray();     
                 Array.Sort(wordTo);   
                 string WordTO = new string(wordTo); 

                    if(WordTO==WordFrom){
                        AnaGrams.Add(s);
                    }
               }

            return AnaGrams;
        }
    }
}
