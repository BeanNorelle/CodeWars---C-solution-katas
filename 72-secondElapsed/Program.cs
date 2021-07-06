using System;
using System.Linq;

namespace _72_secondElapsed
{
    class Program
    {
        static void Main(string[] args)
        {
          int []arr =  new int[] { 1,2,3,10,5 };

            foreach(var ss in SortNumbers(arr)){
                Console.WriteLine(ss);
            }
        }
         public static int[] SortNumbers(int[] nums)
            {
            if(nums.Length==0){
                return new int[0];}
                else
                        
                 nums = nums.OrderBy(c => c).ToArray();
                return nums;
            }
    }
}
