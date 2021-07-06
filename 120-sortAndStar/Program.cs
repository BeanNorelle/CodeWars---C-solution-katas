using System;
using System.Linq;
using System.Text;

namespace _120_sortAndStar
{
    class Program
    {
        static void Main(string[] args)
        {
            string  [] s=  { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps"};
            Console.WriteLine(TwoSort2(s));
        }

          public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);

            StringBuilder stringBuilder = new StringBuilder();

            char [] firstWord = s[0].ToCharArray();
            
            int word = firstWord.Length;
            
                for(int i = 0; i<word;i++)
                {
                    stringBuilder.Append(firstWord[i]); 
                    if(word-1!=i) stringBuilder.Append('*',3);           
                }
            return stringBuilder.ToString();
        } 

        public static string TwoSort2(string [] s)
        {
            Array.Sort(s, StringComparer.Ordinal);

           return  string.Join("***",s[0].ToCharArray());;
        }
    }
}
