using System;
using System.Collections.Generic;
using System.Linq;

namespace _174_AlanPartridge3
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] s = {"London", "Norwich"};
            string [] w = {"Norwich", "Tooting", "Bank", "Rejection", "Disappointment", "Backstabbing Central", "Exeter", "Shattered Dreams Parkway", "Belgium","London"};
            Console.WriteLine(Alan(s));
        }

        static List<string> stations = new List<string>{"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"};
        public static string Alan(string[] x)
        {   

            string yy = "aaaabbbc";

           string xx =  string.Concat(yy.Select(x=> x=='a' ? 'b' : 'a'));

            bool dockedStations = false;
            string result = string.Empty;
            foreach(var com in  stations)
            {
               if(x.Contains(com)) dockedStations = true;
               else dockedStations = false; break;        
            }
            return dockedStations ? "Smell my cheese you mother!" : "No, seriously, run. You will miss it.";
        }


    }
}
