using System;
using System.Linq;

namespace _194_SplitAndAddBothSides
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int [] numbers = {3,234,25,345,45,34,234,235,345};

            SplitAndAdd2(numbers,n).ToList().ForEach(x=>Console.Write(" "+x));
        }

        public static int[] SplitAndAdd(int[] numbers, int n) 
        {   
            if(numbers.Length<=1||n==0) return numbers;
            if(n%2!=0) {
            int ns = numbers.Sum();
            int [] s = {ns};
            return s;
            }

            int half = numbers.Length/2;
            int [] firstList = numbers.Take(half).ToArray();
            int [] SecondList = numbers.Skip(half).Take(half+1).ToArray();
            int seclen = SecondList.Length - 1;
            int firlen = firstList.Length - 1;

            for(int i = 0;i<=firlen;i++)
            {                      
                SecondList[seclen - i] += firstList[firlen - i];
            }

            if(SecondList.Length!=n)
            {
                return SplitAndAdd(SecondList,n);
            }
            else
            return SecondList;
        }

        public static int[] SplitAndAdd2(int[] numbers, int n)
        {
            if (n == 0 ||numbers.Length == 1)
            {
                return numbers;
            }

            var half = numbers.Length / 2;
            int [] firstList = numbers.Take(half).ToArray();
            int [] secondList = numbers.Skip(half).Take(half + 1).ToArray();

            for (int i = secondList.Length - 1; i >= 0; i--)
            {
                if (numbers.Length % 2 == 0)
                {
                    secondList[i] += firstList[i];
                }
                else
                {
                    if (i == 0)
                    secondList[i] = secondList[i];
                    else
                    secondList[i] += firstList[i - 1];            
                }
            }

            if (n > 1)
            {
                return SplitAndAdd2(secondList, n - 1);
            }
            else
            return secondList;
        
        }
    }
}
