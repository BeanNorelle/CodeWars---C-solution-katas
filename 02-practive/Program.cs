using System;

namespace _02_practive
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int previous = 0;
            int current = 1;
            int next = 1;
                     Console.WriteLine("enter a number, then press enter:");
            int a = Int32.Parse(Console.ReadLine());
           
           
            for(int i = 1;i<=a;i++)
            {
                    previous=0;
                    current=1;
                    Console.Write(current+"\t");
                 for(int j=1;j<i;j++){

                                       next = current + previous; //1 2 3 5    
                            Console.Write(next + "\t");
                              previous = current;// 1 1 2 3
                                   current = next; //1 2 3 5
                 }
                     
                           Console.Write("\n");
                                                           
                                
                          
            
          

            }
    }
}
}