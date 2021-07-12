using System;
using System.Linq;

namespace _01_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] array = {1,3,5,7,88,22,46,2};
            string s = string.Join(" ",arr(array)).ToString();
            Console.WriteLine(s);
        }

        public static int[] arr (int [] array)
        {
            return array.Where(x=>x%2==0)
                        .OrderByDescending(x=>x)
                        .Take(3)
                        .ToArray();
  
        }
    }
}
