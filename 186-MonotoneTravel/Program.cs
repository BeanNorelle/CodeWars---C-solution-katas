using System;

namespace _186_MonotoneTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static bool IsMonotone(int[] arr)
        {   int prev = arr[0];
            for(int i =1;i<arr.Length;i++)
            {
                if(arr[i]<prev) return false;

                prev = arr[i];
            }
            return true;
        }
    }
}
