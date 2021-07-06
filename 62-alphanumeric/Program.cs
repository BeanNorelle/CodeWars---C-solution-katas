using System;
using System.Text;

namespace _62_alphanumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(alpaTable());

        }
        public static string alpaTable(){
            // var result = new StringBuilder();
            string table ="";
            for(int i = 'A';i<='Z';i++){
              //  result.Append((char)i);
                table+= (char)i+" = "+ Convert.ToInt32((char)i)+ " | " +
                       //(char)('A' + ((i - 'A'+ 3) % 26))+ "\n"; // 90 + (91+3) % 26  = 94=='D'
                                                                //Console.WriteLine((i & 1) == 1);
                        (char)(i - 'A' + 'a')+ " = "+ Convert.ToInt32((char)(i - 'A' + 'a')) + "\n";
            }
         
            return table;
        }
    }
}
