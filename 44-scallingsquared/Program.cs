using System;
using System.Collections.Generic;

namespace _44_scallingsquared
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(scaling("abcd\nefgh\nijkl\nmnop",2,5));
        }
        public static string scaling(string str,int n,int k){
            
            string repWord="";
            string [] subs = str.Split('\n');
            List<string> list = new List<string>();

           foreach(var s in subs){             
              for(int newline=0;newline<k;newline++){ repWord+="\n";     
                    for(int word=0;word<s.Length;word++){  
                      for(int i=0;i<n;i++){
                          repWord+=s[word];                     
                                 }   
                           } 
                      } 
              
                 } 
                           
          return repWord.Trim();
        }
    }
}
