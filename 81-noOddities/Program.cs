using System;
using System.Linq;

namespace _81_noOddities
{
    class Program
    {
        static void Main(string[] args)
        {
     
            string[] subs ={"one","two",""};    
            string s = "";
            string pref = "";

            subs = subs.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            for(int i=0;i<subs.Length;i++){
            
               if(s!=""&&subs[i]!=""){
                   pref = (subs.Length-2>=i)? ", ": " and ";
                   }           
                    s=s+ pref+ subs[i].ToString();             
            }

            Console.WriteLine(s);
        }
    }
}
