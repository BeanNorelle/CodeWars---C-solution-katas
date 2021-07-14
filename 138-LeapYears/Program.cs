using System;

namespace _138_LeapYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(1984));
        }

          public static bool IsLeapYear(int year)
        {
           if(year%100==0)
           {
               if(year%400==0)
                {
                return true;
                }
                return false;
           }


        }
    }
}
