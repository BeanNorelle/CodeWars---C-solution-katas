using System;

namespace _182_ZeroFill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ZeroFill(11,5));
        }

        public static string ZeroFill(int number, int size)
        {
           number = (number<0) ? number*-1 : number; 
           string num = number.ToString();
          
           int nlength = num.Length;
           if(nlength>size) return num;
           
           int adds = Math.Abs(nlength - size);

           return new string('0',adds) + num; 
        }
    }
}
