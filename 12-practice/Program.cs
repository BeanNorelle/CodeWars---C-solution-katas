using System;

namespace _12_practice
{
    class Program
    {
        static void Main(string[] args)
        {
                int at=0;
                String s = "!333!@!";
               String str = s;
               int slength = str.Length;
                int i=1;
        while((i<=slength)&&(at>-1)){
             
                    
                         at = str.IndexOf("!", 0,slength);
                        if(at>-1){str= str.Remove(at,1);}
                        else{break;}
                        slength = str.Length;
                      Console.WriteLine(at);
                       Console.WriteLine(str);
                  }
                  
                  
        }
          
    }
}
