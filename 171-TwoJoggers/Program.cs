using System;

namespace _171_TwoJoggers
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x = 6;
            int y = 4;
            int item1 = NbrOfLaps2(x,y).Item1;
            int item2 = NbrOfLaps2(x,y).Item2;
            Console.WriteLine(item1 + " " + item2);
        }
         public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            if( x <= 0 || y <= 0 ) throw new Exception("Invalid numbers");

            int max = (y>x) ? y : x;
            int sumMax = max;

            while(true)
            {                   
                if(!IsZero(sumMax,x,y)) break; 
                sumMax += max; 
            }
            return new Tuple<int, int>(sumMax/x, sumMax/y);
        }
        public static bool IsZero(int max,int x,int y) => (max % x != 0|| max % y != 0);

    }
}
