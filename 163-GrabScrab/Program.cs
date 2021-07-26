using System;
using System.Collections.Generic;
using System.Linq;

namespace _163_GrabScrab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"donkey", "pool", "horse", "loop"};
            string s = "oolp";
            
            Grabscrab(s,list).ForEach(x=>Console.WriteLine(x));
        }

         public static List<string> Grabscrab(string anagram, List<string> dictionary)
        {
            List<string> ListOfWords = new List<string>();
            string newWord = SortWords(anagram);

            foreach(string word in dictionary)
            {
                if(newWord==SortWords(word)) ListOfWords.Add(word);
            }
            return ListOfWords;
        }

        public static string SortWords(string word)
        {
            return string.Join("",word.ToCharArray().OrderBy(x=>x));
        }
    }
}
