using System;

namespace _184_SmallestInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] num = {9,2,3,5,7,4};
            Console.WriteLine(FindSmallest(num,"index"));
        }

         public static int FindSmallest(int[] numbers, string toReturn)
        {
            switch(toReturn)
            {
                case "value": return Min(numbers); 
                case "index": return Index(numbers,Min(numbers));
            }
            return 0;
        }
  
        public static int Min(int[]numbers)
        {   int res = numbers[0];
            foreach(int num in numbers)
            {
                if(num<res) res=num;
            }
            return res;
        }

        public static int Index(int[]numbers,int n)
        {   int count =0;
            foreach(int num in numbers)
            {
                if(num==n) return count;
                count++;
            }
            return count;
        }
    }
}
