using System;
using System.Text;

namespace _129_WeirdString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToWeirdCase("Hello World!"));
        }

          public static string ToWeirdCase(string s)
        {
            string [] wordsArr = s.Split(" ");
            int Alenght = wordsArr.Length; int wordL = 0; string word = string.Empty;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < Alenght; i++)
            {
                char [] wordCh = wordsArr[i].ToCharArray();
                wordL = wordsArr[i].Length;

                for(int j=0;j<wordL;j++)
                {   
                    if(j%2==0){
                         sb.Append(wordCh[j].ToString().ToUpper());
                    }
                    else
                    {
                         sb.Append(wordCh[j].ToString().ToLower());
                    }            
                }
                if(i!=Alenght) sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
