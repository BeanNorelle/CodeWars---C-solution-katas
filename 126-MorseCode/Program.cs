using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
namespace _126_MorseCode
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string [] morseCode = {
            "...", "... " 
            "...---...",
            "···· · −·−−   ·−−− ··− −·· ·"};
            foreach(string s in morseCode)
            {
            
              Console.WriteLine("\nIn MorseCode |"+s+"|\nThe message is: |"+Decode(s)+"|\n");
            }
           
        }
      public static string Decode(string morseCode)
    {   
        morseCode.Trim();
        

        return MorseCode.Get(morseCode).ToString();
     }
  }
}