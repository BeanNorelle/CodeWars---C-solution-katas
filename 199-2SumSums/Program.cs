using System;
using System.Collections.Generic;
using System.Linq;

namespace _199_2SumSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = {2, 4, 6, 10};
            int min = 6;
            int max = 10;
            Console.WriteLine(SumOfTwoSumTargets(numbers,min,max));
        }

        public static int SumOfTwoSumTargets (int[] numbers, int min, int max)
        {   
            HashSet<int> HashNum = new HashSet<int>();
            int sum = 0;
            int len = numbers.Length;
            
            for(int i = 0; i < len-1; i++)
            {
                for(int j = 1; j < len; j++)
                {
                    sum = numbers[i]+numbers[j];
                    if(sum >= min && sum <max )
                    { 
                        HashNum.Add(sum);
                    }
                }
            }      
            return HashNum.Sum();
        }

    }
}
