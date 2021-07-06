using System;

namespace _53_convertmpgkpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Converter(12));
        }
        public static double Converter(int mpg)
            {
               
                return Math.Round((mpg*1.60934)/4.54609,2);
            }
    }
}
