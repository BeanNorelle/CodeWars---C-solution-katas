using System;
using System.Linq;
namespace _15_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a2 = {2,3,4,15,6,7};
            int limit2 = 10;

                    Console.WriteLine(se(a2,limit2));
           
        }
        public static bool se(int[] a, int limit){
         
         bool isbool=true;
         foreach(var i in a){
                if(i>limit){
                    isbool =  false;
                    break;
                }
                else 
                {
                    isbool = true;
                }
         }

        return isbool;
         
        }
    }
}
