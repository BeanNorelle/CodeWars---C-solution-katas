using System;
using System.Collections.Generic;
using System.Linq;
namespace _215_LeastCommonDenominator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> nums = new List<int>{4,3};
            Console.Write(LeastCommonMultiple(nums));
        }
        public static int LeastCommonMultiple(List<int> Nums)
        {
           Nums.OrderByDescending(x=>x);

            if(Nums.Count()==0) return 1;
            if(Nums.Contains(0)) return 0;
            int lcm = Nums.Last();

            List<int> set = new List<int>();
                  
                  while(true)
                  {
                      foreach (var element in Nums)
                        {
                            set.Add(lcm % element);
                            Console.WriteLine(lcm +" "+ element);
                        }
                        if(set.Sum() == 0)
                        {
                            return lcm;
                        }
                        else
                        {
                            set.Clear();
                            lcm++;
                        }
                  }
        }
    }
}
