using System;
using System.Linq;

namespace _142_ValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses("c((d))s"));
        }
        public static bool ValidParentheses(string input)
        {
            int Parenthes= 0;

            char [] ch = input.ToCharArray();

            int cLength = ch.Length;

            for(int i =0;i<cLength;i++)
            {
                if(ch[i]=='(') Parenthes++;

                if(ch[i]==')') Parenthes--;

                if(Parenthes<0) return false;
            }

            return (Parenthes==0);
        }

           public static bool ValidParentheses(string input)
        {
        }
    }
}
