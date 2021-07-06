using System;
using System.Linq;
using System.Collections.Generic;

namespace _57_countduplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "aabbdddddccc";
        //  Console.WriteLine($"{word} has {CountDuplicates(word)} duplicates.");
            char[] charrs = word.ToCharArray();
        foreach(var s in charrs){
            Console.Write(s);
        }
        }
        // public static int CountDuplicates(string word)
        // {
        //     char []wordarr = word.ToLower().ToCharArray();
            
        //         int max = 0;
        //             int count=0;
        //             for(int i=0;i<wordarr.Length;i++){
        //                   count =0; 
        //                    for(int j=0;j<wordarr.Length;j++){
                
        //                        if(wordarr[i]==wordarr[j]){
        //                              count++;
        //                               if(count>max){
        //                                  max=count;                              
        //                                 count=0;
        //                                }
        //                            }      
        //                        }                      
        //                    }
                    
        //        return  max;
        //     }

        public static int CountDuplicates(string word){

               return word.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
        }         
        }
    }

