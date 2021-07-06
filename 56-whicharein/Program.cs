using System;
using System.Collections.Generic;
using System.Linq;
namespace _56_whicharein
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a1 = {"arp", "live", "strong"};
            string[] a2 = {"lively", "alive", "harp", "sharp", "armstrong"};

            foreach(var s in str(a1,a2)){
                Console.WriteLine(s);
            }

        }
        public static string[] str(string[] a1,string[] a2){  
            List<string> nameslist = new List<string>();
                foreach(var compareFrom in a1){
                    foreach(var compareTo in a2){
                        if(compareTo.Contains(compareFrom)){ 
                            nameslist.Add(compareFrom);
                        }     
                    }   
                }
                nameslist.Sort();
            return nameslist.Distinct().ToArray();
        }

        public static string[] str2(string[] a1,string[] a2){
             return (from a in a1 from b in a2 where b.Contains(a) select a).Distinct().OrderBy(e => e).ToArray();
        }
    }
}
