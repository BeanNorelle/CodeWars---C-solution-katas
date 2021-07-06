using System;
using System.Linq;

namespace _103_BitToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            reverseBit(100);
            reverseBit(101);
        }
        
        public static long reverseBit(long n)
        {
            Console.WriteLine("{0}\t",n);                 // long n input variable

            string nStr = Convert.ToString(n,2);      // converts long integer to string but in binary form
            Console.WriteLine("{0}",nStr);           

            string revStr = string.Concat(nStr.Reverse());  // reverses string binary
            Console.WriteLine("{0}\t",revStr);         

            long IntStr = Convert.ToInt64(revStr,2);  // string binary to long integer
            Console.WriteLine("{0}",IntStr);        

            return Convert.ToInt64(string.Concat((nStr).Reverse()),2);
        }
    }
}
