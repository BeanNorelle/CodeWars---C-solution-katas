using System;
using System.Collections.Generic;
using System.Linq;

namespace _204_WeirdIPv6
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(ParseIPv6("1111:1111:1111:1111:1111:1111:1111:1111"));
        }

        public static string ParseIPv6(string iPv6)
        {
            string validhex = "1234567890ABCDEF";
            List<string> Blocks = new List<string>();
            string sb = string.Empty;
            int sum = 0;
            for(int i=0;i<iPv6.Length;i++)
            {
                if(validhex.Contains(iPv6[i]))
                {
                   sum += validhex.IndexOf(iPv6[i]) + 1;
                }
                else 
                {
                   sb += Convert.ToString(sum);
                   sum = 0;
                }
                if(i==iPv6.Length-1)
                {
                    sb+=sum;
                }
            }
            return sb;
           
        }
    }
}
