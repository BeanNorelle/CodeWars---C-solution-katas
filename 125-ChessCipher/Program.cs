using System;
using System.Text;
using System.Collections.Generic;

namespace _125_ChessCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChessEncryption("hello"));
        }

        public static string ChessEncryption(string msg)
        {
          StringBuilder sb = new StringBuilder();

          Dictionary<char,string> ChessDict = new Dictionary<char, string> {
                { 'a', "d3" }, { 'b', "d4" }, { 'c', "d5" }, { 'd', "d6" },
                { 'e', "d7" }, { 'f', "e7" }, { 'g', "e6" }, { 'h', "e5" },
                { 'i', "e4" }, { 'j', "e3" }, { 'k', "e2" }, { 'l', "f2" },
                { 'm', "g2" }, { 'n', "h2" }, { 'o', "h1" }, { 'p', "g1" },
                { 'q', "f1" }, { 'r', "e1" }, { 's', "d1" }, { 't', "c1" },
                { 'u', "b1" }, { 'v', "a1" }, { 'w', "a2" }, { 'x', "b2" },
                { 'y', "c2" }, { 'z', "d2" }, { ' ', " " },
            };

            int sLength = msg.Length;
            
            for(int i =0;i<sLength;i++)
            {
                sb.Append(ChessDict[msg[i]]);
            }          
          return sb.ToString();
        }
    }
}
