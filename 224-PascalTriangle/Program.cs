using System;

namespace _224_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pascal(3));
        }

          public static long[][] Pascal(long depth)
            {   
                long[][] Triangle = new long[depth][];
                
                for(int i = 0 ; i < depth ; i++){
                    Triangle[i] = new long[i + 1];
                    Triangle[i][0] = 1;
                    Triangle[i][i] = 1;

                    for(int j = 1 ; j < i ; j++){
                        Triangle[i][j] = Triangle[i - 1][j] + Triangle[i - 1][j - 1];
                    }
                }
            return Triangle;
            }
    }
}
