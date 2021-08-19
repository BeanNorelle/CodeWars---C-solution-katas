using System;
using System.Collections.Generic;

namespace _195_SplitInParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitInParts("asdadsdasda",2));
        }

        public static string SplitInParts(string s, int partLength)
        {  
            List<string> Whole = new List<string>(); 
            string sb = string.Empty;

            for(int i = 1;i<=s.Length;i++)
            {
                sb+=s[i-1];
                if(i%partLength==0||i==s.Length) 
                {
                    Whole.Add(sb);
                    sb=string.Empty;
                }
                
            }
            return string.Join(" ", Whole);;    
        }
    }
}
