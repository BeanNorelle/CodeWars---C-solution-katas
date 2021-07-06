using System;

namespace _85_creditCardMasking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("heasdasdllo"));
        }
         public static string Maskify(string cc)
        {   char[] c = cc.ToCharArray();
            int s = c.Length;
            for(int i= s-5;i>=0;i--){
                c[i]='#';
            }

            return new string(c);
        }
    }
}
