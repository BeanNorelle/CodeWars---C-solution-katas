using System;

namespace _68_KnightMove
{
    class Program
    {
        static void Main(string[] args)
        {
           string positon = "g1";
           Console.WriteLine(count(positon));
        }
        public static int count(string cell
        ){            
           int res = 8;
                if (cell[0].Equals('b') || cell[0].Equals('g'))
                    res = res - 2;
                if (cell[1].Equals('2') || cell[1].Equals('7'))
                    res = res - 2;
                if (cell[0].Equals('a') || cell[0].Equals('h'))
                    res = res / 2;
                if (cell[1].Equals('1') || cell[1].Equals('8'))
                    res = res / 2;
                
                return res; 
        }

    }
}
