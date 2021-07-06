using System;

namespace _20_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Client = {0,1,0,1};
            string str = string.Join("",Client);
            Console.WriteLine(bintoint(str)+"\t"+str);
        }

        

        static int bintoint(string bins){

                return Convert.ToInt32(bins,2);
        }
    }
    
}
