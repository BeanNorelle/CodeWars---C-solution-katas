using System;
using System.Collections.Generic;
using System.Linq;

namespace _220_UpAndDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UpAndDown("after be arrived two My so"));
        }

        public static string UpAndDown(string words)
        {
            
            List<string> nlist = WordRe(words);
            for(int i=0;i<nlist.Count();i++)
            {
                if((i+1)%2==0)
                {
                    nlist[i] = nlist[i].ToUpper();
                }
            }
            return string.Join(" ",nlist);
        }
        public static List<string> WordRe(string words)
        {
            List<string> wordList = words.Split(' ').ToList();
            int counter = 1;
            string temp = string.Empty;
       
            for(int i = 0;i<wordList.Count()-1;i++)
            {
                wordList.ForEach(x=>Console.Write(x+" "));
                Console.WriteLine(" ");
                   if(counter%2==0)
                   {
                       if(!(wordList[i].Count()>=wordList[i+1].Count()))
                       {
                           temp = wordList[i];
                           wordList[i]=wordList[i+1];
                           wordList[i+1] = temp;
                       }
                   }
                   else
                   {
                       if(!(wordList[i].Count()<=wordList[i+1].Count()))
                       {
                           temp = wordList[i];
                           wordList[i]=wordList[i+1];
                           wordList[i+1] = temp;
                       }
                   }
                   counter++;
            }
            return wordList;
        }
    }
}
