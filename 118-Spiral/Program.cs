using System;

namespace _118_Spiral
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int [,] arr = Spiralize(5);
            int length = 5;

            for(int i = 0;i<length;i++)
            {
                Console.Write("\n");
                for(int j = 0;j<length;j++)
                {
                    Console.Write(arr[i,j]);
                }
            }
        }

        private const int Path = 1;
         public static int[,] Spiralize(int size)
        {
     
            int[,] SpiralArr = new int[size, size];
          //  for(int Pstart = 0, Pmax = N-1; Pmax-Pstart >= 0; Pstart+=2, Pmax-=2){
            for(int Pstart = 0, MaxSize= size-1; MaxSize-Pstart >= 0; Pstart+=2, MaxSize-=2)
            {
                
                for(int i = Pstart; i <= MaxSize; i++) 
                {               
                        SpiralArr[MaxSize, (i-1 > 0) ? i - 1 : i] = 1;        
                        SpiralArr[MaxSize, i] = Path;
                }
                
                for(int i = Pstart; i < MaxSize; i++)    SpiralArr[i, MaxSize] = Path;                             
                for(int i = MaxSize; i > Pstart; i--)    SpiralArr[MaxSize, i] = Path;               
                for(int i = MaxSize; i > Pstart+1; i--)  SpiralArr[i, Pstart] = Path;
            }
            return SpiralArr;
            }
        }
    }
