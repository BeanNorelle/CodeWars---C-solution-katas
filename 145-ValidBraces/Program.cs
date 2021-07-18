using System;
using System.Collections.Generic;

namespace _145_ValidBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validBraces("({})"));
        }
        public static bool validBraces(String braces)
        { 
            Stack<char> st = new Stack<char>();
            char [] ch = braces.ToCharArray();

            for(int i =0; i<ch.Length;i++)
            {
                switch(ch[i])
                {
                    case ')': st.Push(ch[i]); continue;
                    case '}': st.Push(ch[i]); continue;
                    case ']': st.Push(ch[i]); continue;
                    default:
                        if((st.Count==0||st.Pop()!='['||st.Pop()!='{'||st.Pop()!='(')) 
                        {
                            return false;
                        }     
                    continue;                   
                }
            }
            return (st.Count==0);
        }
    }
}
