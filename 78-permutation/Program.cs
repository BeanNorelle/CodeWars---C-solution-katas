using System;
using System.Collections.Generic;
using System.Linq;

namespace _78_permutation
{
    class Program
    {
                static void Main(string[] args)
            {
                string str = "ABC";
                char[] charArry = str.ToCharArray();
       

                foreach(var s in Permute(charArry, 0, 2)){
                    Console.WriteLine(s);
                }
                Console.ReadKey();
            }

            static List<string> Permute(char[] arry, int i, int n)
            {
                List<string> l = new List<string>();
                int j;
             
                    for(j = i; j <=n; j++)
                    {
                        Swap(ref arry[i],ref arry[j]);
                          if (!l.Contains(new string (arry))){
                         l.Add(new string (arry));}      
                    if(i!=n){i++;}
                        Swap(ref arry[i], ref arry[j]); //backtrack
                    if (!l.Contains(new string (arry))){
                         l.Add(new string (arry));}
                    }  

              return l;          
            }

            static void Swap(ref char a, ref char b)
            {
                char tmp;
                tmp = a;
                a=b;
                b = tmp;
            }

    }
}