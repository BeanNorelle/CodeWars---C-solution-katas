using System;
using System.Linq;
using System.Collections.Generic;

namespace _173_Permute
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglePermutations("abcd");
        }

        public static List<string> SinglePermutations(string str)
        {
            var slist = new List<string>();
            if (str.Length == 1){
            return new List<string> { str }; 
            }
            else
            {
            var Permute = SinglePermutations(str.Substring(1));
           
                string words = string.Empty;

                foreach(var word in Permute)
                {
                    for(int i = 0;i<word.Length+1;i++)
                    {
                        words = word.Substring(0,i) + str[0] + word.Substring(i);
                        Console.WriteLine(words);
                        slist.Add(words);
                    }
                }
            }
            return slist.Distinct().ToList();
        }
    
    }
}
