using System;

namespace _192_BattleOfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Battle("ABC","Z"));
        }
        public static string Battle(string x, string y)
        {
           int xs = GetScore(x);
           int ys = GetScore(y);

           if(xs>ys) return x;
           if(ys>xs) return y;

           return "Tie!";
        }
        public static int GetScore(string str)
        {  
            int sum = 0;
            foreach(char ch in str)
            {
                sum += Convert.ToInt32(ch)-64;
            }
            return sum;
        }
    }
}
