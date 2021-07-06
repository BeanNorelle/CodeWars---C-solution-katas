using System;

namespace _47_drawasquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateShape(2));
        }
        public static string GenerateShape(int n)
            {
                string linesq = "";

                
                for(int j=0;j<n;j++){ 
                     if(j>0) linesq+="\n";
                
                for(int i=0;i<n;i++){
                    linesq+="+";     
                }
                }
                return linesq;
            }

    }
}
