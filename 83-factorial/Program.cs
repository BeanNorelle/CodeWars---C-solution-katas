using System;

namespace _83_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine(factorial(4));
           Console.WriteLine((4*(6/2))*(4*(6/2)));
             Console.WriteLine(4*(6-1)*4);
          //  foreach(int n in fibonacci(4)){
            //    Console.WriteLine(fibonacci(10)+ " ");
          //  }
        }

        public static int factorial(int n){
            int s =1;
            for(int i=1;i<=n;i++){
                s*=i;
            }
            return s;
        }

        public static int[] fibonacci(int n){
            int prev = 0; int curr =1; int next=0;
            int[]arr = new int[n];
            for(int i =0;i<n;i++){
             next = curr+ prev;
            Console.Write(prev);
            prev = curr;
            curr=next;         
            }

            return arr;
        }
    }
}
