using System;
using System.Collections.Generic;

namespace _70_mul3or5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10)+" ");
            
        }
        public static int Solution(int value)
            {
                int count=0;
                List<int> nlist = new List<int>();
                for(int i = value-1;i>0;i--){
                    if(i%3==0||i%5==0){
                        nlist.Add(i);
                    }
                }
                    foreach(var s in nlist){
                        count+=s;
                    }
                return count;
            }
    }
}
