using System;
using System.Linq;

namespace _97_ConvStrToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("Hello_world_you"));
        }
          public static string ToCamelCase(string str)
        {
            string []strArr = str.Split('-','_');
            string CamelCase = strArr[0];
            
            for(int i=1;i<=strArr.Length-1;i++){
            
                string word = strArr[i];

                CamelCase += Char.ToUpper(word[0])+word.Substring(1);
            }

            return CamelCase;
        }
    }
}
