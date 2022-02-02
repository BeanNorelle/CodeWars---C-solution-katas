using System;
using System.Collections.Generic;
using System.Linq;

namespace _217_Leastcommonmultilpe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Nums = new List<int>{13, 10, 8, 12, 16};
            Console.Write("this is the ans " + LeastCommonMultiple(Nums));
        }

        public static int LeastCommonMultiple(List<int> Nums)
        {
            if(Nums.Contains(0)) return 0;
            if(Nums.Count()==0) return 1;

            int lcm = 0;
            int counter = 1;
            int max = Nums.Max();
           // Nums.ForEach(x=>Console.Write(" "+x));
         
              
                for(int i = 0;i<Nums.Count();i++)
                {         
                          Console.WriteLine(max+" "+counter+" "+Nums[i]);              
                        if(((max * counter) % Nums[i] == 0))
                        {                         
                            lcm =  max * counter;
                            if(Nums.Count()-1==i) return lcm;
                        }
                        else 
                        {
                             i=-1;
                             counter++;
                        }
                }
            return lcm;
        }
    }
}
