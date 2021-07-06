using System;

namespace _51_change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DutyFree(12, 50, 1000));
            Console.WriteLine(50/100);
        }
         public static int DutyFree(int normPrice, int Discount, int hol)
        {
           return (int)(hol / (normPrice * (Discount / 100f)));      
        }
    }
}
