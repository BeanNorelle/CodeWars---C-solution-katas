using System;
using System.Collections.Generic;
using System.Linq;

namespace _159_PrizeDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
            int [] we = new int[] {4, 2, 1, 4, 3, 1, 2};
            int n = 2;
            Console.WriteLine(NthRank(st,we,n));

        }

        public static string NthRank(string st, int[] we, int n)
        {  
             string [] listNames = st.Split(",");  

            if(st==string.Empty) return "No participants";
            if(listNames.Length<n) return "Not enough participants";

            return DetermineWinner(listNames,we,n);               
        }
        
        public static string DetermineWinner(string[] list,int [] we,int pickNumber)
        {
             Dictionary<string,int> DictNames = GetDictionaryOfContestants(list,we);
             string Winner = DictNames.OrderBy(k=>k.Key).OrderByDescending(v=>v.Value).ElementAt(pickNumber-1).Key;

            return Winner;
        }
        public static Dictionary<string,int> GetDictionaryOfContestants(string [] Names,int [] we)
        {
                Dictionary<string,int> DictNames = new Dictionary<string,int>();
                
                int NameScore =0; int count = 0;
                foreach(string name in Names)
                {   
                    for(int i =0;i<name.Length;i++)
                    {
                        NameScore += (int)Char.ToLower(name[i])-96;
                    }           
                    DictNames.Add(name,(NameScore+name.Length)*we[count]);  
                    NameScore=0; 
                    count++;
                }
                return DictNames;
        }
    }
}
