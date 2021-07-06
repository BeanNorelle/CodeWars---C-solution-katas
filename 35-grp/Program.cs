using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace _35_grp
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] ret = { 1,1,0,1,0,0,0,0,1,1,0,0,0,0,0,0};             

       Stopwatch sw = new Stopwatch();

        sw.Start();
          foreach(var ss in DataReverse(ret)){
              Console.Write(ss);
          } 
        sw.Stop();
            Console.WriteLine("Elapsed: {0}ms",sw.Elapsed.TotalMilliseconds);
        
         sw.Start();
          foreach(var ss in DataReverse2(ret)){
              Console.Write(ss);
          } 

        sw.Stop();
            Console.WriteLine("Elapsed: {0}ms",sw.Elapsed.TotalMilliseconds);  
        }

        //first solution
           public static int[] DataReverse(int[] ret) {
           
           List<string> ret2 = new List<string>();
           int arrayc = ret.Count();
             int []ret3 = new int [arrayc];
            
             int count = 0;
             string str = "";

         foreach(var num in ret){         
            
                if(count!=8){
                    str += num;           
                    count++;
                }  
                if(count==8)
                {
                   ret2.Add(str);                 
                    count =0;
                    str="";
                }           
         }

         ret2.Reverse();
         string sc = "";
         foreach (var item in ret2)
         {
            sc += item;
         }

          foreach(var lt in sc){
     
          }
          for(int k = 0;k<sc.Length;k++){
                  ret3[k] = ((int)Char.GetNumericValue(sc[k]));
          }

         return ret3;
        }

//second solution
            public static int[] DataReverse2(int[] data)
            {
                int[] bits = data;

                for(int i = 0; i < data.Length; i+=8)
                {
                Array.Reverse(bits, i, 8);
                }
                
                Array.Reverse(bits);
                
                return bits;
            }

        }
    }

