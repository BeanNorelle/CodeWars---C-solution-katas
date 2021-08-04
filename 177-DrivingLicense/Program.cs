using System;
using System.Linq;

namespace _177_DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] data = { "John", "James", "Smiths", "01-Jan-2000", "M" };
            DateTime dob  = DateTime.Parse( "01-Jan-2000");
            int year = dob.Year;

            Console.WriteLine(dob.Month.ToString("D2"));
        }

         public static string driver (params string[] data)
        {        
         string first =  ((data[2].Length>5) ? data[2].Substring(0,5) : data[2] + new string('9',5-data[2].Length)).ToUpper();    
         string second = SixEleven(data[3],data[4]);
         string third = TwelveThirteen(data[0],data[1]);
         return first+second+third+"99"+"AA";
        }

        public static string SixEleven(string DOB,string Sex)
        {   
             string [] Months = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
             string [] DOBarr = DOB.Split("-");
             string second = DOBarr[2][2].ToString();
             int month = Array.IndexOf(Months,DOBarr[1].Substring(0,3))+1;
             string third = Sex=="M" ?  month.ToString("D2") : (month+40).ToString("D2");
             string fourth = DOBarr[0];
             string fifth = DOBarr[2][3].ToString();

             return second+third+fourth+fifth;
        }

        public static string TwelveThirteen(string FN,string MN)
        {
            string f = FN.Substring(0,1);
            string m = (MN=="") ? "9" : MN.Substring(0,1);
            return f+m;
        }
        
    }
}
