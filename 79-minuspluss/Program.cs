using System;
using System.Linq;

namespace _79_minuspluss
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine(formatDuration(11101));
        }   
        public static string formatDuration(int seconds){
        string s ="";
        int secs = seconds;
        int[] timeArr = {60*60*24*365,  60*60*24, 60*60,   60,  1};
        string[] strArr = {"year","day","hour","minute","second"};

        if(secs == 0){ return "now";}

   
            for(int i=0;i<timeArr.Length;i++){

                    int divTime = secs /timeArr[i]; 
                    secs = secs % timeArr[i];

              if(divTime !=0){
                        
                        string pref = "";
                        if(s!=""){ pref = (secs==0)?" and" : ", ";  }    

                        s = s +pref+" "+divTime.ToString()+" "+strArr[i]; 
                        s += divTime > 1 ? "s" : "";
                }
            }   
            return s;    
          
        }
    }

 }
    