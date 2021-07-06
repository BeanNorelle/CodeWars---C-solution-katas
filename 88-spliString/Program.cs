using System;
using System.Collections.Generic;

namespace _88_spliString
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var s in Solution("abcdefg"))
            Console.WriteLine(s);
        }
          public static string[] Solution(string str)
        {   List<string> l = new List<string>();
            char []arr = str.ToCharArray(); string scn = "";
            for(int i=0;i<arr.Length;i+=2){
                scn = (i+1>arr.Length-1&&i%2==0) ? "_" : Convert.ToString(arr[i+1]);
                l.Add(Convert.ToString(arr[i])+scn);
            }
            return l.ToArray();
        }
    }
}
