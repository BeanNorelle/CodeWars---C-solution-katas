using System;
using System.Text.RegularExpressions;

namespace _80_removeafterstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "www.google.com/asdasda/?dfs/#asda";     

              Console.WriteLine(Regex.Match(text, @"[^#]+").Value);
        }
    }
}
