using System;
using System.Linq;
using System.Text;

namespace _214_TestingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testString());
        }

        public static string testString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append("asd").ToString();
        }
    }
}
