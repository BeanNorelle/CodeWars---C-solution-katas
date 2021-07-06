using System;
using System.Collections.Generic;
namespace _26_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
    

            int num = 2;
       
               Console.Write(arrystr(num)[1]);

             static string []arrystr(int n)
             {
                 string[]arr=new string[n];
                 for(int i=0;i<n;i++){
                    arr[i] = "as";
                 }

                return arr;
             }     
       }
       
       
    }
}

