using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _24_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = "Gerry kerry Mark";
            string[] strings = Regex.Split(names, @"\W|_");
            string lname ="";
            string fname ="";
            var count = strings.Count();
    
            for(int i = 0;i<count;i++){
                    for(int j =0;j<strings[i].Length;j++){
                             char ab = ((strings[i])[j]);
                             if(j==0){                          
                            lname = Convert.ToString((strings[i])[0]);
                             fname = fname + lname + ". ";
                             }
                          
                    }
                     
                 }
   
            Console.Write(fname.Replace(" ",String.Empty));

        }
    }
}
