using System;
using System.Collections.Generic;

namespace _77_humanreadable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(formatDuration(15731080));
        }
         public static string formatDuration(int seconds){

             if(seconds==0){return "now";}
             int s = seconds; int min =0; int hours =0; int days =0; int year =0;
              string buildS=""; int switcher = 0;
              if(seconds>59){s = seconds%60; min=seconds/60;} 
              if(min>59){hours=min/60; min=min%60;}
              if(hours>23){ days=hours/24;hours=hours%24;}
              if(days>364){ year=days/365; days=days%365;}

                string minS = (min>1)?"minutes": "minute";
                string secS = (s>1)?"seconds": "second";
                string hrS = (hours>1)?"hours": "hour";
                string dayS = (days>1)?"days": "day";
                string yearS = (year>1)?"years": "year";

                string sStr = (s==0) ? null : s+" "+secS;
                string mStr = (min==0) ? null : min+" "+minS;
                string hStr = (hours==0) ? null : hours+" "+hrS;
                string dStr = (days==0) ? null : days+" "+dayS;
                string yStr = (year==0) ? null : year+" "+yearS;
                List<string> strBuild = new List<string>();

            if(sStr!=null)  {strBuild.Add(sStr);}
            if(mStr!=null)  {strBuild.Add(mStr);}
            if(hStr!=null)  {strBuild.Add(hStr);}
            if(dStr!=null)  {strBuild.Add(dStr);}
            if(yStr!=null)  {strBuild.Add(yStr);}
            
                int sB = strBuild.Count;
                switcher = (sB==1) ? 1 : (sB==2) ? 2 : (sB==3) ? 3: (sB==4) ? 4:(sB==5) ? 5: 6; 
         Console.WriteLine(sB);
                   switch(switcher){
                    case 1: buildS += strBuild[0]; break;
                    case 2: buildS += strBuild[1] +" and "+ strBuild[0]; break;
                    case 3: buildS += strBuild[2] +", "+strBuild[1] +" and "+ strBuild[0]; break;
                    case 4: buildS += strBuild[3] +", "+ strBuild[2] +", "+strBuild[1] +" and "+ strBuild[0]; break;
                    case 5: buildS += strBuild[4] +", "+ strBuild[3] +", "+ strBuild[2] +", "+strBuild[1] +" and "+ strBuild[0]; break;
                    default: break;            
                }

             return buildS;
        }

    }
}
