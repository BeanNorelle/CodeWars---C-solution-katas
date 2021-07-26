using System;
using System.Linq;

namespace _160_FindNumbers
{
    class Program
    {
        static void Main(string[] args)
        {   int [] numbers = {1,2,3,4,5,6,7,8,9};
            int divisor = 2;
            int [] nums = numbers.Select(x=>x).Where(x=>x%divisor==0).ToArray();

            string dna = "UUUU";
            string rna = string.Join("",dna.Select(x=>(x=='U') ? 'T' : x));

            Console.Write(rna);
        }
    }
}
