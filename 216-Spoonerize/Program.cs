using System;
using System.Collections.Generic;
using System.Linq;

namespace _216_Spoonerize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Spoonerize("Pack of lies"));
        }
         public static string Spoonerize(string str)
        {
            List<string> strArr = str.Split(" ").ToList();
            char one = (strArr.First())[0];
            char two = (strArr.Last())[0];

            strArr[0] = two +  strArr[0].Substring(1);
            strArr[strArr.Count-1] = one + strArr[strArr.Count-1].Substring(1);

            return string.Join(" ",strArr).ToLower();

        }
    }
}
