using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace _34_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Bill Gates";

          
            
         Stopwatch sw = new Stopwatch();


    Console.WriteLine("First solution:");
        for(int i = 0; i<3;i++){
                  sw.Start();                   
                  initials(str);
                  sw.Stop();
                  Console.WriteLine(sw.Elapsed.TotalMilliseconds);  
        }

            Console.WriteLine("Second solution:");                    
        for(int i = 0; i<3;i++){
                    sw.Start();                   
                   toInitials(str);
                    sw.Stop();      
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);       
        }

             Console.WriteLine("Third solution:");                       
        for(int i = 0; i<3;i++){
                    sw.Start();                   
                   toInitials2(str);
                    sw.Stop();      
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);       
        }


        }

        //First solution
        public static string initials(string str){
             string[] words = str.Split(' ');
           
           string strjoin = "";
            foreach(var ch in words){
            strjoin += (string.Join("",ch[0])+".");
            }  
                return strjoin.Trim();     
          }
    
                    //second solution
                public static string toInitials(string name)
            {
                return string.Join(" ", name.Split().Select(s => s[0] + "."));
            }

            //Third Solution
             public static string toInitials2(string name)
                {
                return Regex.Replace(name, @"(\S)\S+\b", "$1.");
                }
}

}
