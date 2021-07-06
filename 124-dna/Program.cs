using System;
using System.Text;

namespace _124_dna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeComplement("TAACG"));
        }
         public static string MakeComplement(string dna)
        {

            StringBuilder sb = new StringBuilder();
            int ChLength = dna.Length;

            for(int i = 0; i<ChLength;i++)
            {
                switch(dna[i])
                {
                    case 'A': sb.Append('T'); break;
                    case 'T': sb.Append('A'); break;
                    case 'G': sb.Append('C'); break;
                    case 'C': sb.Append('G'); break;
                    default: throw new ArgumentException("invalid string");
                }
            }
            return sb.ToString();
        }
    }
}
