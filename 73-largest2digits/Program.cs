using System;

namespace _73_largest2digits
{
    class Program
    {
        static void Main(string[] args)
        {
        //     string str ="1234567890";
        //    Console.WriteLine("Max is {0}", GetNumber(str));
        //     Console.WriteLine(Convert.ToInt32("32"));

            twiceage(30,0);

        }
          public static int GetNumber(string str) 
        {
            int prev=0;
            int max =0;
            for(int i=0;i<str.Length-1;i+=5){
                prev = Convert.ToInt32(str[i].ToString()+str[i+1].ToString()+str[i+2].ToString()+str[i+3].ToString()+str[i+4].ToString());
                if(max<prev){
                    max=prev;
                }
            }
            return max;
        }

        public static int twiceage(int dadYears,int sonYears){
            
               int count = 0;
            if(sonYears*2<dadYears){ count=1;
                while(dadYears/2!=sonYears){
                    count++;
                    dadYears-=1;       
                }
            }
            else{ count=0;
                while(dadYears/2!=sonYears){       
                    dadYears +=1;
                    count++;
            }        
          }     
                Console.WriteLine(count);
                 return count;
        }
    }
}
