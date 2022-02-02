using System;

namespace _212_MakeRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Recursion(5));
        }

        public static int Recursion(int n)
        {   int sum = n;
            int num = n;
            if(n>1)
                {   
                    num--;
                    sum += Recursion(num);
                }
            return sum;
        }
    }
}
