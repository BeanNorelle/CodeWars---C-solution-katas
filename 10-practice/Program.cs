using System;

namespace _10_practice
{
    class Program
    {
        static void Main(string[] args)
        {
    
              Console.Write("here it is," + Same(3));
      
        }

        public static String Same(int num){
        String a = (num>=0) ? "yes" : "no";

        return a;

        }
    }
}
