using System;
using System.Linq;

namespace _176_ClockwiseSpiral
{
    class Program
    {
        static void Main(string[] args)
        {

            int [,] test = CreateSpiral(3);
            int row = test.GetLength(0);
            int col = test.GetLength(1);
            for(int i = 0;i<row;i++)
            {
                Console.WriteLine("");
                for(int j = 0;j<col;j++)
                {
                    Console.Write(test[i,j]);
                }
            }
        }
         public static int[,] CreateSpiral(int N)
        {
        int[,] Spiral = new int[N,N];
        int Count = 1;
        int hor = 0, vert = N - 1;

            while (Count <= Spiral.Length)
            {
  
                for (int i = hor; i <= vert; i++)
                {
                    Spiral[hor, i] = Count++;
                }
         
                for (int j = hor + 1; j <= vert; j++)
                {
                    Spiral[j, vert] = Count++;
                }
            
                for (int i = vert - 1; i >= hor; i--)
                {
                    Spiral[vert, i] = Count++;
                }
            
                for (int j = vert - 1; j >= hor + 1; j--)
                {
                    Spiral[j, hor] = Count++;
                }

                hor++;  vert--;
            }
        return Spiral;
        
        }
    }
}
