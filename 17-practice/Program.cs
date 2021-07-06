using System;

namespace _17_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int []arr = {1,2,5,4,5,6,7,19};
        for(int i=0;i<arr.Length-1;++i){
             Console.WriteLine(arr[i]);
             if(arr[i+1]!=(arr[i])+1){
                 Console.WriteLine("non"+arr[i+1]);
             }
               
                 
             }
   
         }
        }
    }

