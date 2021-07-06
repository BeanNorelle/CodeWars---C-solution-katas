using System;

namespace _91_moveZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arrint = {0, 0, 0, 1, 2, 0, 1, 0, 0, 1};
            foreach(var s in MoveZeroes(arrint)){
                Console.Write(s);
            }
        }
         public static int[] MoveZeroes(int[] arr)
            {   int count =0;
                
                for(int i =0;i<arr.Length;i++)  
                        if(arr[i]!=0){ 
                                arr[count++] = arr[i]; }
                            while (count < arr.Length){
                            arr[count++] = 0;}
                                                                      
                
                   return arr;
            }
    }
}
