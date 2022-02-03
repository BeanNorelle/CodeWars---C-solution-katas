using System;

namespace _226_Ponyexxpress
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] station = {50,50};
            Console.WriteLine(PhonyExpress(station));
        }

        public static int PhonyExpress(int [] stations)
        {   
            int travel = 0;
            int rider = 1;
            foreach(int n in stations)
            {   
                travel+=n;
                if(travel>100){
                travel=0;
                rider++;
                }
            }
            return rider;
        }
    }
}
