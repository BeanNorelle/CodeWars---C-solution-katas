using System;

namespace _202_TrainingTakeTenMin
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] walk =  {"w","e","w","e","w","e","w","e","w","e","w","e"};
            Console.WriteLine(IsValidWalk(walk));
        }

        public static bool IsValidWalk(string[] walk)
        {
                        if(walk.Length>10) return false;
            int vert = 0;
            int horz = 0;
            foreach(var direction in walk)
            {
                switch(direction)
                {
                    case "n": vert++; break;
                    case "s": vert--; break;
                    case "w": horz++; break;
                    case "e": horz--; break;
                }
            }
            return (vert==0&&horz==0);
        }
    }
}
