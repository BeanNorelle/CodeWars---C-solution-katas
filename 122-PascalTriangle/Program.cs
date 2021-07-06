using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace _122_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

        for(int i = 1;i<=10;i++){

            sw.Start();
            PascalsTriangle(3);
            sw.Stop();
            Console.WriteLine("{0} ms", sw.Elapsed.TotalMilliseconds);
          //  sw.Restart();
        }
            int n = 4;
            int nSquare = (int)Math.Pow(n,2);

        }

          public static List<int> PascalsTriangle(int n) {

        int SizeOfTriangle = n * (n + 1) /2;

         List<int> nList = new List<int>(SizeOfTriangle);

            int c = 1;
              for(int i = 0; i < n; i++)
              {
                  for(int j = 0;j<=i;j++)
                  {
                      if(j==0||i==0){
                      c=1;
                      }
                      else
                      c=c*(i-j+1)/j;
                      nList.Add(c); 
                  }
              }
              return nList;
          }    
        private static int SizeOfList(int n)=> Enumerable.Range(1,n).Sum();
        
    }
}
