using System;

namespace _102_NarcisiticNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsNarcissistic(11513221922401));
        }
          public static bool IsNarcissistic(UInt64 n)
        {
            char [] intN = n.ToString().ToCharArray(); 
            UInt64 sum =0;

                foreach(var s in intN){
                    sum += (UInt64)Math.Pow(char.GetNumericValue(s),intN.Length);
                }

            if(sum==n) return true;

            return false;
        } 

        public static string str(string word)
        {
            char [] strCh = word.ToCharArray();
            string strB = "";

            foreach(var s in strCh){
                 strB += (Char.IsLower(s)) ? s.ToString().ToUpper() : s.ToString().ToLower();
            }

            return strB;
        }

    }
}
