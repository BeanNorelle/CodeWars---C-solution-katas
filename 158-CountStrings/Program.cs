using System;
using System.Collections.Generic;
using System.Linq;

namespace _158_CountStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Count("BABACBA");
        }
         public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char,int> newDict = new Dictionary<char, int>();
            List<char> chArr = str.ToCharArray().Distinct().OrderBy(x=>x).ToList();
       
            int arLength = chArr.Count; int count =0;
            for(int i =0;i<arLength;i++)
            {   count = 0;
                for(int j=0;j<str.Length;j++)
                {
                    if(chArr[i]==str[j]) count++;
                }
                newDict.Add(chArr[i],count);
            }
            return newDict;
        }
    }
}
