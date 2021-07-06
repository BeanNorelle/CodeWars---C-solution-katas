using System;

namespace _74_humanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(str(2450001000022));
            
        }
    
    public static string str(long time){
        string n= "";
        long modulosSecs = time%60;
        long min = time/60; long month = 0;
        long hours = 0; long days=0; long years = 0;
            
            if(min>=60){
                hours = min/60;  
                min=min%60; 
            }
            if(hours>24){
                days=hours/24;
                hours = hours%25;
            }
            if(days>30){
                month = days/30;
                days = days%30;
            }
            if(month>12){
                years = month/12;
                month = month%12; 
            }
            string dayNight = "";
            if(hours>12)
            {
                 dayNight = "PM";
            }
            else{
                dayNight = "AM";
            }
            Console.Write("Years:"+years+
            "\nMonths:"+month+"\nDays:"+days+
            "\nHours:"+hours+"\nMinutes:"+min+
            "\nSeconds:"+modulosSecs+
            "\nTime of Day:"+dayNight);
        return n;
    }
    }
}
