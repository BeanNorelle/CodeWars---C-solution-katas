using System;

namespace _23_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double tres = 0;
           double dou=0;
           double dou2=0;
            int n =9;
	        for(int i=0;i<=n;i++){

          dou= 1/(1+tres);
         
          dou2=dou2+dou;
          Console.WriteLine("dou is equals:"+dou);
           tres=tres+3;
        }
        Console.Write(dou2.ToString("f3"));
        }
    }
}
