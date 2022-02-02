using System;

namespace _211_CourseraPracticeW3
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(Increment(0));
             Console.WriteLine(Increment(3));
             Console.WriteLine(Increment(36));
             Console.WriteLine(Increment(102));
        }

        public static int Increment(int n)
        {   int count = 1;
            int sum = 0;
            while(count < n)
            {   
                sum = (n % count == 0) ? sum += count : sum;
                count++;
            }
            return sum;
        }
    }
}
