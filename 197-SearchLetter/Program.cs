using System;
using System.Text;

namespace _197_SearchLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Change("ab"));
        }

        public static string Change(string input)
        {
            
            string output = new string('0',26);
            int index = 0;
            

            foreach(char ch in input)
            {
                if(Char.IsLetter(ch))
                {
                    index = Convert.ToInt32(Char.ToLower(ch))-97;
                    output = output.Remove(index, 1).Insert(index, "1");  
                }
            }
            return output;
        }
    }
}
