using System;

namespace _76_oddonenout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortMyString("Codewars"));
        }
         public static string SortMyString(string s)
        {   string even = "";
            string odd ="";
            int count = 0; 
           foreach(var ss in s){
               count++;
               if(count%2==0){
                   even+=ss;
               }
               else{
                    odd+=ss;
               }
           }
                          return odd+" "+even;
        }
    }
}
