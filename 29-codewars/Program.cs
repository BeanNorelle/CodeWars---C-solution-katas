using System;

namespace _29_codewars
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = new int[]{1,7,2,8,2};

      
        char dir = 'R';
         Array.Sort(arr);
        if(dir=='L'){
                  
            Array.Sort(arr);
        }
        else
        if(dir=='R')
        {
        Array.Reverse(arr);  
        }

           foreach(var ir in arr)
           {
               Console.Write(ir+", ");
           }
        }
    }
}
