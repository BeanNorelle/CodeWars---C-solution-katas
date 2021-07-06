using System;
using System.Collections.Generic;

// The new "Avengers" movie has just been released! There are a lot of people 
//at the cinema box office standing in a huge line. Each of them has a single 100, 
//50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.
// Vasya is currently working as a clerk. He wants to sell a ticket to every 
//single person in this line.

// Can Vasya sell a ticket to every person and give change if he initially has no 
//money and sells the tickets strictly in the order people queue?
// Return YES, if Vasya can sell a ticket to every person and give 
//change with the bills he has at hand at that moment. Otherwise return NO.

namespace _30_VasyaChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listm = new int[]{25,50,25,50,100};
            List<int> firstlist = new List<int>();

                string result = "";
                  int quart=0;
                foreach(var elem in listm){
                bool exist = firstlist.Contains(25);
                 bool exist2 = firstlist.Contains(50);
              
          


                if(elem==25){
                    firstlist.Add(25); 
                    result="YES";  
                    quart+=1;      
                } 
                else
                if(elem==50&&exist==true){
                    firstlist.Add(50); 
                    firstlist.Remove(25);
                    result="YES";
                     quart-=1;  
                }
                else
                if(elem==100&&((exist2==true&&exist==true||quart>=3))){                                        
                            if(exist2==true){
                                firstlist.Remove(50); 
                                firstlist.Remove(25);                  
                                quart-=1;                
                                }
                            else 
                                    if(exist2==false)        
                                {
                                firstlist.Remove(25); 
                                firstlist.Remove(25);
                                firstlist.Remove(25);
                                    quart-=3;                  
                                }
                      result = "YES";
                     firstlist.Add(100);
                   }
        else
              result = "NO";
                       
            }
            Console.WriteLine("these are the initial queue:");
         foreach(var s2 in listm){
                Console.Write(s2+", ");
            }
            Console.WriteLine("these are the change collection:");
            foreach(var ss in firstlist){
                Console.Write(ss+", ");
            }

            Console.WriteLine(result+"  \n 25s are this many:"+quart);
        
        }
    }
}
