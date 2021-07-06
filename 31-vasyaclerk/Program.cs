using System;
using System.Collections.Generic;

namespace _31_vasyaclerk
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] listm = new int[]{25,25,25,100,25,50,25,50,100};
            List<int> firstlist = new List<int>();

                string result = "YES";
                  int quart=0;
                foreach(var elem in listm){
                bool exist = firstlist.Contains(25);
                 bool exist2 = firstlist.Contains(50);
                 if(result=="YES"){
                        switch(elem){
                            case 25: firstlist.Add(elem);
                            quart+=1;
                                result="YES";
                                break;

                                case 50: 
                                if(exist==true){
                                    firstlist.Add(elem);
                                    firstlist.Remove(25);
                                    quart-=1;
                                    result="YES";
                                }
                                else
                                {
                                result="NO";}
                                break;

                                case 100: 
                                if(elem==100&&((exist2==true&&exist==true||quart>=3))){                                        
                                        if(exist2==true){
                                            firstlist.Remove(50); 
                                            firstlist.Remove(25);                  
                                            quart-=1;                
                                            }
                                        else 
                                                if(exist2==false)        
                                            {
                                            firstlist.Remove(25); 
                                            firstlist.Remove(25);
                                            firstlist.Remove(25);
                                                quart-=3;                  
                                            }
                                result = "YES";
                                firstlist.Add(100);
                            }
                            else
                            {
                            result="NO";}
                                break;
                        }
                      
                  

                 }
                    
            }

            Console.Write("The new list is:\n");
            foreach(var fl in firstlist){
                Console.WriteLine(fl);
            }
            Console.Write("there is change? "+result+" Quarters count:"+quart);
      
        }
    }
}
