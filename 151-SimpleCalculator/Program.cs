using System;

namespace _151_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator(1,2,'&'));
        }

         public static double Calculator(double a, double b, char op)
        {
            switch(op)
            {
                case '-': return a-b;
                case '+': return a+b;
                case '*': return a*b;
                case '/': return a/b;
                default: throw new ArgumentException();
            }
            
        }
    }
}
