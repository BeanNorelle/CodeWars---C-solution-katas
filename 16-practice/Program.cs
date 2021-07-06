using System;
using System.Collections.Generic;
using System.Linq;
namespace _16_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

                int []list ={5,2,2,4,5,6};

            int []uniquelist = list.Distinct().ToArray();
            
            int elements = uniquelist.Count();
            int []newul = new int[elements];
            for(int i=0;i<elements;i++){
               newul[i] = uniquelist[i];
            }
                Console.WriteLine(String.Join(",",uniquelist));

        }
    }
}
