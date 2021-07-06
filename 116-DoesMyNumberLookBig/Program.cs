using System;

namespace _116_DoesMyNumberLookBig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(153));
        }
          public static bool Narcissistic(int value)
        {
            char []valueCh = value.ToString().ToCharArray();
            int CharLength = valueCh.Length; 

            long Sum = 0;
            for(int i = 0; i<CharLength;i++)
            {
                Sum += (long)Math.Pow(Char.GetNumericValue(valueCh[i]),CharLength);
            }

            if(Sum==value) return true;

            return false;
        }
    }
}
