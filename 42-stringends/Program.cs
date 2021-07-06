using System;
using System.Diagnostics;

namespace _42_stringends
{
    class Program
    {
        static void Main(string[] args)
        {
               Stopwatch sw = new Stopwatch();
            // sw.Start();
            // Console.WriteLine(Solution("asdfga","gaasdss"));
            // sw.Stop();
            // Console.WriteLine("Elapsed time {0}", sw.Elapsed.TotalMilliseconds);

            sw.Start();
            Console.WriteLine(stringend("asdfga","gaasdss"));
            sw.Stop();
            Console.WriteLine("Elapsed time {0}", sw.Elapsed.TotalMilliseconds);

           
        }


          public static bool Solution(string str, string ending)
            {
                return str.EndsWith(ending);
            }
        public static bool stringend(string word, string ends)
        {
            if(word.Length<ends.Length||word.Length==0||ends.Length==0||word==null||ends==null){
               return false;
            }
       
            else{
                string str="";
            for(int i=ends.Length;i!=0;i--){
               str += word[word.Length-i];
            }

           if(str==ends){return true;} 
           else
           return false;
            }
        }
    }
}
