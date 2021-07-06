using System;
using System.Collections.Generic;

namespace _105_GetBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortBytes(3735928559));
        }
        public static uint SortBytes(uint number)
        {
            var num = BitConverter.GetBytes(number);

            Array.Sort(num);
            foreach(var b in num){
            Console.WriteLine(b);}

            UInt32 uintNum = BitConverter.ToUInt32(num);
            return uintNum;
        }
    }
}
