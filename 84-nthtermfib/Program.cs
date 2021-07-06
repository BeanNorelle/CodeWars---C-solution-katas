using System;

namespace _84_nthtermfib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the {0}th term of fibonacci seq: {1}",1,nthFib(6));
        }
        public static int nthFib(int n){

            int prev =0; int curr =0; int next =1;
            for(int i =1;i<=n ;i++){
                if(n==i){return curr;}
                curr = next;
                next = prev + curr;
                prev = curr;           
            }
            return prev;

           
        }
    }
}
