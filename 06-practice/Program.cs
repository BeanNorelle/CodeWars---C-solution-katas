using System;

namespace _06_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
           int[] ar = new int[5];
            int j=0;
            int i=0;
                while(j<5){
                    j++;
                    
                    
                    sum=i+j;
                    ar[i] = sum;
                    i++;
                }

            for(i=0;i<5;i++){
                Console.WriteLine(ar[i]);
            }


        }
    }
}
