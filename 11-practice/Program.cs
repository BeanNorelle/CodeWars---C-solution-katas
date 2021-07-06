using System;
using System.Collections.Generic;

namespace _11_practice
{
    class Program
    {
 
        static void Main(string[] args)
        {

        int count = 1;            
       var names = new List<string>();

           for(int i=1;i<=5;i++){
       names.Add(Console.ReadLine());
           }
           foreach(var name in names){
               
               Console.Write(count+": "+name+"\t");
               count++;
           }
           
           
        }
    }
}
