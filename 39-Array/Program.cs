using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace _39_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] input = {1,5,7,8,9};
           
             Stopwatch sw = new Stopwatch();
        //     sw.Start();
        //    foreach(var i in CountPositivesSumNegatives(input)){
        //        Console.WriteLine(" "+ i);
        //    }
        //    sw.Stop();
        //    Console.WriteLine("Elapsed: {0}", sw.Elapsed.TotalMilliseconds);


               sw.Start();
           foreach(var i in CountPositivesSumNegatives2(input)){
           //    Console.WriteLine(" "+ i);
           }
           sw.Stop();
           Console.WriteLine("Elapsed: {0}", sw.Elapsed.TotalMilliseconds);

            
               sw.Start();
           foreach(var i in CountPositivesSumNegatives3(input)){
           //    Console.WriteLine(" "+ i);
           }
           sw.Stop();
           Console.WriteLine("Elapsed: {0}", sw.Elapsed.TotalMilliseconds);

        }

        public static int[] CountPositivesSumNegatives(int[] input)
            {
            if(input!=null){
                if(input.Length!=0){
                int max=0;
                int min=0;
                foreach(int i in input){
                if(0<i){
                max++;
                    }             
                    if(0>i)
                    {
                    min+=i;
                    }
                    }
        List<int> addList= new List<int>();
            addList.Add(max);
            addList.Add(min);
                
            return addList.ToArray();
            }

            else
            {
                Console.WriteLine("Is empty or null");
                return new int[0]; 
            }
            }
            else
                Console.WriteLine("Is null");
                return new int[0];
            
         }

           public static int[] CountPositivesSumNegatives2(int[] input)
    {
        if(input == null || !input.Any())
        {
            return new int[] {};
        }
        
        int countPositives = input.Count(n => n > 0);
        int sumNegatives = input.Where(n => n < 0).Sum();

        return new int[] { countPositives, sumNegatives };
    }

      public static int[] CountPositivesSumNegatives3(int[] input)
    {
        if(input == null || input.Length == 0) return new int[0];
        int pos = 0;
        int neg = 0;
        foreach(var i in input)
        {
          if(i <= 0) neg+= i;
          else      pos++;
        }
        
        return new int[] { pos, neg};
    }
    }
}
