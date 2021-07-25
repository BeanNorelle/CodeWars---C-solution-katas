using System;

namespace _157_MeanSquareError
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr1 = {10, 20, 10, 2};
            int [] arr2 =  {10, 25, 5, -2};  
            Console.WriteLine(Solution(arr1,arr2));
        }

         public static double Solution(int[] firstArray, int[] secondArray)
        {
            double diff = 0; 
            double sum =0;   
            int arrLength = firstArray.Length;
            for(int i =0;i<arrLength;i++)
            {
                diff = Math.Abs(firstArray[i]-secondArray[i]);
                sum += Math.Pow(diff,2);
            }
            return sum/arrLength;
        }
    }
}
