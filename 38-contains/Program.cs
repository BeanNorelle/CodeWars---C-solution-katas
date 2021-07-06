using System;
using System.Linq;
using System.Diagnostics;

namespace _38_contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1 2 -3 4 5 6";
        
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Console.WriteLine(HighAndLow(str));
        sw.Stop();
        Console.WriteLine("elapsed: {0}",sw.Elapsed.TotalMilliseconds);
        

          sw.Start();
        Console.WriteLine(HighAndLow2(str));
        sw.Stop();
        Console.WriteLine("elapsed: {0}",sw.Elapsed.TotalMilliseconds);
        }

         public static string HighAndLow(string str)
                {
                   int[] ia = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); 
                               return string.Join(" ", ia.Max(),ia.Min());
                }
            
                 public static string HighAndLow2(string str)
                {
                   int[] ia = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); 
                    int max = ia[0];
                    int min = ia[0];
                        foreach(var i in ia){
                            if(max<i){
                                max=i;
                            }
                            if(min>i){
                                min=i;
                            }
                        }

                        return (max+" "+min);
                }
             }
    }

