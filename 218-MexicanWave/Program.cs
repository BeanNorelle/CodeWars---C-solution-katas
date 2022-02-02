using System;
using System.Collections.Generic;
using System.Linq;

namespace _218_MexicanWave
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MexicanWave(" gap ").ForEach(x=>Console.WriteLine(x));
        }

        public static List<string> MexicanWave(string Str)
        {
          List<string> slist = new List<string>();
            string s = String.Empty;
            for(int i = 0; i<Str.Count();i++)
            {
                s = string.Empty;
                for(int j=0;j<Str.Count();j++)
                {   
                    if(Str[i]==' ') break;
                    if(i==j)
                    {
                        s+= Str[j].ToString().ToUpper();  
                    }
                    else
                    {
                        s+=Str[j].ToString();
                    }
                }
                if(s != string.Empty) slist.Add(s);     
            }
  
            return slist;
        } 
    }
}
