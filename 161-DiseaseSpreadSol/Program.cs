using System;
using System.Linq;

namespace _161_DiseaseSpreadSol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Epidemic(int tm, int n, int s0, int i0, double b, double a)
        {
            double dt = tm/n;
            double[] Infected = new double[n+1];
            double[] Suspect = new double[n+1];
            double[] Recovered = new double[n+1];
            
            Infected[0] = i0;
            Suspect[0] = s0;     
            Recovered[0] = 0;

            for (int i=0; i<n; i++){
                Suspect[i + 1] = Suspect[i] - dt * b * Suspect[i] * Infected[i];
                Infected[i + 1] = Infected[i] + dt * (b * Suspect[i] * Infected[i]- a*Infected[i]);
                Recovered[i + 1] = Recovered[i] + dt * Infected[i]*a;           
            }
            return MaxInfected(Infected);
        }

        public static int MaxInfected(double [] n)
        {   
            double max = 0;
            for(int i=0;i<n.Length;i++)
            {
                if(max<n[i]) max = n[i];
            }
            return (int)Math.Truncate(max);
        }
    }
}
