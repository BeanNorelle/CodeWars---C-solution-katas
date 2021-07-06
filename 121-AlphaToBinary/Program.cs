using System;
using System.Text;

namespace _121_AlphaToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Bean that is my Name");

          Console.WriteLine(generateBinary("I am Bean that is my Name and you should do well to remember that"));
        }

        public static string generateBinary(string name)
        {
             StringBuilder sb = new StringBuilder();
             char [] charN = name.ToCharArray();
            int count = 0;
            foreach (char c in charN)
            {     count++;
                sb.Append(Convert.ToString(c, 2));
            
                if(count==5){sb.Append('\n'); count=0;}
              
            }
         
         return sb.ToString();
        }
    }
}
