using System;

namespace _213_Recursion02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOf(64,4)==1);
        }
        public static int IsPowerOf(int m,int n)
        {
            int div = 0;
            int ans = 0;

            if(m>=n)
            {  
               div = m/n;
               ans = IsPowerOf(div,n);
            } 

          

            return ans;

        }
    }

}
