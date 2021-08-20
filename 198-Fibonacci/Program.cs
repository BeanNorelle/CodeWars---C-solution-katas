using System;

namespace _198_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(12));
        }
        public static int fib(int n)
        {   
            int cur = 1;
            int pre = 0;
            int nex = 0;
            for(int i =0;i<n;i++)
            {   
                pre = cur;
                cur = nex;
                nex = cur + pre;
            }
            return cur;
        }
    }
}
