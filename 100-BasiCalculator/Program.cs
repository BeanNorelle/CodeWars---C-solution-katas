using System;

namespace _100_BasiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string n = "+";
            int num = 2;
            int num2 = 3;
        }
        public static int result (int num1, string str, int num2){

            switch (str)
            {
                case "+":  return(num1 + num2);
                case "-":return (num1 - num2); 
                case "/": return (num2==0) ? throw new ArgumentException("Cannot divide to zero") : (num1 / num2); 
                case "*": return (num1 * num2); 
                default: throw new ArgumentException("Invalid Operator");
            }

        }
    }
}
