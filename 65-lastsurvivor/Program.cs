using System;

namespace _65_lastsurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "HelloWorld!";
            int [] num = {1,1,1};
            Console.WriteLine("String is: {0}",LastSurvivor(str,num));

        }
        public static string LastSurvivor(string letters, int[] coords)
            {       
                string str = letters;
                for(int i =0;i<coords.Length-1;i++){
                        str = str.Remove(coords[i],1);
                }

                return str;
            }
    }
}
