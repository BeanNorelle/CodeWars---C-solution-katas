using System;
using System.Linq;

namespace _69_findoddint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int []num = {20,1,2,2,20};
            Console.WriteLine("\n"+find_it(num));
        }
        public static int find_it(int[] seq) 
        {
    
            foreach(var s in seq){
                int count=0;
                foreach(var l in seq){
                   if(s==l){ count++;}         
                }
                if((count%2)==1){
                    return s; 
                } 
            }        
           // Console.WriteLine(seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key);
            return -1;
        }
        public static int find_it2(int[]seq){
           return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }


    }
}
