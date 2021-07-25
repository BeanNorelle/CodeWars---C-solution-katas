using System;

namespace _153_TrainingOnThrowingDarts
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] n = {1, 2, 3, 4};
            Console.WriteLine(ScoreThrows(n));
        }

         public static int ScoreThrows(double[] radii)
        {   
            int sum =0; int count =0;
            foreach(var radius in radii)
            {   
                 if(radius>10) sum+=0;

                 if(radius>=5&&radius<=10) sum+=5;

                 if(radius<5){sum+=10; count++;}

                 if(radii.Length==count) sum+=100;
            }
            return sum;          
        }
    }
}