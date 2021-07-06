using System;

namespace _66_twodimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,]sint =  {{2,3,4},
                           {3,4,5},
                           {1,6,7}};
                     Console.Write(Result(sint));
        }
         public static int Result(int[,] array)
            {   int rownum =0; int rowmul =1;

                for(int r=0;r<array.GetLength(0);r++){
                        rownum=0;
                    for(int c=0;c<array.GetLength(1);c++){
                        rownum +=(array[r,c]);
                    }
                    rowmul*=(rownum);
                  }
            
                return rowmul;
            }
    }
}
