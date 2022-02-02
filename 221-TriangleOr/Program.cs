using System;

namespace _221_TriangleOr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle(6));
        }
        public static bool Triangle(int n)
        {
            for(int i = 0;i<=n;i++)
            n-=i;

            return n==0;
        }
    }
}
