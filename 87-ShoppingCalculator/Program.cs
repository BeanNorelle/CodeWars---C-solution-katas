using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _87_ShoppingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(intFilter("asdasd 3")+3);
           
        }
        //  public static List<(string, string, string)> ShoppingCalculation(List<string> input) {
        //      return input;
        //     }


            
            //gets Name or subject from string
            public string Name(string str){string[] sName = str.Split(' ');
                return sName[0];
            }

            //filters integer value from string
             public static int intFilter(string str) => Convert.ToInt32 (Regex.Match (str, @"\d+").Value);
          
            

    }
}
