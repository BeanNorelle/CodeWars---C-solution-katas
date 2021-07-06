using System;
using System.Collections.Generic;

namespace _46_rgbtohex
{
    class Program
    {
        static void Main(string[] args)
        {

        string fullhex="";
        fullhex += (hexConversion(27));
        fullhex += (hexConversion(12));
        fullhex += (hexConversion(12));

        Console.WriteLine(fullhex);
        }
        public static string hexConversion(int newx){ 
               
            string result = "";
            List<int> arr = new List<int>();
            if(newx>255){newx=255;}
            if(newx<0){newx=0;}
            arr.Add(newx/16);
            arr.Add(newx%16);
            
            foreach(var dec in arr){
                if(dec>10){
                      switch(dec){
                        case 10: result+="A"; break;
                        case 11: result+="B"; break;
                        case 12: result+="C"; break;
                        case 13: result+="D"; break;
                        case 14: result+="E"; break;
                        case 15: result+="F"; break;             
                   }
                }
                else{
                    result+= Convert.ToString(dec);
                }
            }
            return result;
        }
    }
}
