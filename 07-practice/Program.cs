using System;

namespace _07_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
           while(true){

               int rando = rand.Next(10);
               string bin = Convert.ToString(rando);
                Console.Write(bin);
           }
        }
    }
}
