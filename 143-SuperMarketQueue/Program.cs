using System;

namespace _143_SuperMarketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static long QueueTime(int[] customers, int n)
        {
            int [] cashiers = new int [n];

            for(int i=0; i<customers.Length;i++)
            {
                int MinumunQueue = GetPosition(cashiers);
                cashiers[MinumunQueue] += customers[i];
            }
            return GetMax(cashiers);
        }

        private static int GetMax(int [] array)
        {
            int max =0;
            for(int i =0;i<array.Length;i++)
            {
                if(array[i]>max) max=array[i];
            }

            return max;
        }
        private static int GetPosition(int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {      
                if (array[i] < array[min]) min = i;
            }
            return min;
        }
    }
}
