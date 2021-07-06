using System;
using System.Text;
using System.Collections.Generic;

namespace _110_StripComments
{
    class Program
    {
        static void Main(string[] args)
        {   string word = "apples, pears # and bananas\ngrapes\nbananas !apples";
            string [] w = {"#", "!" };

            

            Console.WriteLine(StripComments(word,w));
        }

        public static string StripComments(string text, string[] commentSymbols)
        {
        
        string [] strArr = text.Split('\n');

            for(int i =0;i<strArr.Length;i++)
            {
                for(int j =0; j<commentSymbols.Length;j++)
                {    
                int ind = strArr[i].IndexOf(commentSymbols[j]);
                if(ind>=0) 
                {    
                    strArr[i] = strArr[i].Substring(0,ind);
                 }
                }
                strArr[i] = strArr[i].TrimEnd();
            }

             return string.Join('\n',strArr);
        }

        public static string StripComments2(string text, string [] commentSymbols)
        {
            string[] lines = text.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < commentSymbols.Length; j++)
                    {
                        int index = lines[i].IndexOf(commentSymbols[j]);
                        if (index >= 0)                    
                            lines[i] = lines[i].Substring(0, index);              
                    }
                    lines[i] = lines[i].TrimEnd();
                }
          return string.Join("\n", lines);
        }
    }
}
