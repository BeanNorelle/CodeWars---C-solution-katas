using System;
using System.Diagnostics;
using System.Linq;
namespace _37_encryt
{
    class Program
    {
        static void Main(string[] args)
        {
           string str = "The less he spoke the more he heard";
          
          Stopwatch sw = new Stopwatch();

          sw.Start();
          Console.Write(encrypt(str));
        sw.Stop();

        Console.Write("\t{0}",sw.Elapsed.TotalMilliseconds);

        }

        public static string encrypt(string str)
        {
             string[] words = str.Split(' ');
           string newstr = "";
           string revstr ="";
            string ress = "";

           if(str!=string.Empty){
                foreach(var ss in words){
                        newstr+=Math.Abs(ss[0]);
                        revstr ="";
                        ress = "";
                    for(int i=1;i<ss.Length;i++){                
                        revstr+=ss[i];
                    }               
                      

                 for(int i=0;i<revstr.Length;i++){
                
                if(i ==revstr.Length-1){
                    ress += revstr[0];
                }
                else 
                if(i==0)
                {
                    ress += revstr[revstr.Length-1];
                }
                else
                if(i>=0){
                     ress+=revstr[i];
                    }
                
            }

                        newstr+=ress+ " ";
                }
                         return newstr.Trim();}
           else{
                         return "";
                 }
        }
    }
}
