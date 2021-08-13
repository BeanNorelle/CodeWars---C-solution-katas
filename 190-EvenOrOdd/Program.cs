using System;

namespace _190_EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd("1234"));
        }
        public static string EvenOrOdd(string str)
        {
            int odd = 0; int num = 0;
            int even = 0;
           foreach(char ch in str)
           {
               num = CharInt(ch);
               if(num%2==0){
                    even += num;}
               else{
                    odd += num;}
           }
            return OddOrEven(odd,even);
        }

        public static int CharInt(char ch)
        {
            return (int)char.GetNumericValue(ch);
        }

        public static string OddOrEven(int odd,int even)
        {
            if(odd>even) return "Odd is greater than Even";
            if(even>odd) return "Even is greater than Odd";
           
            return"Even and Odd are the same";
        }
    }
}
