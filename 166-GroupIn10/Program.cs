using System;
using System.Collections.Generic;
using System.Linq;

namespace _166_GroupIn10
{
    class Program
    {
        static void Main(string[] args)
        {  
        
        int [] sss = {8, 12, 38, 3, 17, 19, 25, 35, 50,110}; 

         var n = GroupIn10(sss);

          for(int i =0;i<n.GetLength(0);i++)
          {    
              Console.Write('\n');
              for(int j =0;j<n[i].Length;j++)
              {
                  Console.Write(n[i][j]+" ");
              }
          }

        }
        public static int[][] GroupIn10(int [] n)
        {
           if(n.Count()==0) return new int [0][];

           int MaxElement = (n.Max()/10)+1;        
           int [][] Groups = new int [MaxElement][];
           
           for(int i =0;i<MaxElement;i++)
           {
               Groups[i] = GroupIntegers(i,n);
           }

        return Groups;
        }
        public static int[] GroupIntegers (int nInt, int[] nArray)
        {
            List<int> nlist = new List<int>();
            for(int i = 0;i<nArray.Length;i++)
            {
                if(nInt==nArray[i]/10) nlist.Add(nArray[i]);
            }
            return nlist.OrderBy(x=>x).ToArray();
        }
        
    }
}
