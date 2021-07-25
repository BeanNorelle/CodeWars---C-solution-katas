using System;
using System.Collections.Generic;

namespace _152_MakeDeadFishSwim
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "iiisdoso";

            foreach(var ss in Parse(s))
            {
                Console.Write(ss + " ");
            }
        }
     
        public static int[] Parse(string data)
        {
            List<int> nList = new List<int>();
            int sum = 0; 
            foreach(char ch in data)
            {   
                switch(ch)
                {
                    case 'i': sum+=1; break;
                    case 's': sum = (int)(Math.Pow(sum,2)); break;
                    case 'd': sum-=1; break;
                    case 'o': nList.Add(sum); break;
                    default: break;
                }
            }
            return nList.ToArray();
        } 
    }
}