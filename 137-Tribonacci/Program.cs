using System;
using System.Collections.Generic;
using System.Linq;

namespace _137_Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] n = {16, 2, 10};
         
            foreach(var s in Tribonacci(n,2))
            {
                Console.Write(s+" ");
            }
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
           if(n==0) return new double[0];

           List<double> result = new List <double>(signature);

           double one = signature[0];
           double two = signature[1];
           double three =signature[2];

           double next = 0;

           for(int i =3;i<n;i++)
           {  
               next = one + two + three;
               one = two;
               two = three;
               if(next!=0) three = next;  

               result[i] = three;
           }
           return  result.Take(n).ToArray();
        }
    }
}
