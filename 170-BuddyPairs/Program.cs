using System;

namespace _170_BuddyPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Buddy(381,4318));
        }

        public static string Buddy(long start, long limit)
        {
            string result="Nothing";

            for(long n=start;n<=limit;n++)
            {
                long number=sumdivisors(n)-1;
                long number2=sumdivisors(number)-1;
                Console.WriteLine(n+" "+number);
                if(number>n&&number2==n)
                {
                    result = $"({n} {number})"; 
                    break;
                }             
            }
            return result;
        }
        public static long sumdivisors(long number) 
        {
            long sum=1;
            double max = Math.Sqrt(number)+1;
            for(long i=2;i<max;i++)
            {
                if (number%i==0) 
                {
                    sum+=i;
                    sum+=(number/i);
                }
            }
           return sum;
        }
    }
}
