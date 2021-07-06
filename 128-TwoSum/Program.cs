using System;
using System.Linq;

namespace _128_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {   
            int [] numArr = {2, 2, 3};
            int num = 4;

            foreach(var s in TwoSum(numArr,num))
            {
              //  Console.WriteLine(s);
            }
        }

        public static int[] TwoSum(int[] numbers, int target)
        {   
            int [] TwoSum = new int [2];
            int nlength = numbers.Length;

            for(int i = 0 ;i<nlength-1; i++)
            {
                for(int j =1;j<nlength;j++)
                {
                    if((numbers[i]+numbers[j])==target)
                    {   
                        TwoSum[0] = i;
                        TwoSum[1] = j; 

                        return TwoSum;
                    }
                }
            }
            return TwoSum;
        }

        public static int[] TwoSum2(int[] numbers, int target)
        {       
          return numbers.Select((x,i)=>new [] {i, 
                   Array.IndexOf(numbers,target-x,i+1)})
                        .First(x => x[1] != -1);         
      }
    }
}
