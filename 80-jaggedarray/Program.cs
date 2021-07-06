using System;

namespace _80_jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
        int[][] pyramid = new int[n][];
                    for(int i = 1; i <= n; i++) {
                    int[] layer = new int[i];
                    for(int j = 0; j < i; j++) {
                        layer[j] = 1;
                    }
                    pyramid[i-1] = layer;
                    }
               

               for(int k=0;k<pyramid.Length-1;k++){
                    Console.WriteLine(pyramid[k][0]);
                    for(int m=0;m<pyramid.Length-1;m++){
                        Console.WriteLine(pyramid[m][k]);
                    }
               }
        }
    }
}
