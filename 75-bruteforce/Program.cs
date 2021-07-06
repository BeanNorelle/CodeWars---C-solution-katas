using System;
using System.Diagnostics;
namespace _75_bruteforce
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            Console.WriteLine("Password is: {0}",bruteForce());
            sw.Stop();

            string secs = "";
            if(sw.Elapsed.TotalMilliseconds>1000){
             secs = Convert.ToString(sw.Elapsed.TotalMilliseconds/1000)+"secs";
            } else 
             secs = Convert.ToString(sw.ElapsedMilliseconds)+"ms";
            Console.WriteLine("Elapsed time: {0}",secs);
        }
        public static string bruteForce(){

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            string PassGen ="";
            string pass = "PLDTWIFIAAASBB";
            
                
                    foreach(var a in alpha){
                        foreach(var a2 in alpha){
                             foreach(var a3 in alpha){
                                  foreach(var a4 in alpha){
                                    foreach(var a5 in alpha){
                                        foreach(var a6 in alpha){
                            PassGen = "PLDTWIFI"+Convert.ToString(a) + Convert.ToString(a2)+Convert.ToString(a3)
                                            +Convert.ToString(a4) + Convert.ToString(a5)+Convert.ToString(a6);
                                            Console.WriteLine(PassGen);
                        if(PassGen==pass){return PassGen;}
                                       }   
                                    }
                                }    
                            }                  
                         }
                    }
            return PassGen;
        }
    }
}
