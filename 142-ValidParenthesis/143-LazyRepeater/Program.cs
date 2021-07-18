using System;

namespace _143_LazyRepeater
{
    class Program
    {
        static void Main(string[] args)
        {   
             Func<char> abc = MakeLooper("abc");
            Console.WriteLine(abc());
            Console.WriteLine(abc());
            Console.WriteLine(abc());
            Console.WriteLine(abc());


        }
        static  int count = 0;
         public static Func<char> MakeLooper(string str)
        {
            return() => {
            if(count>str.Length-1) 
                count =0;

            return str[count++];
            };
        }
    }
}
