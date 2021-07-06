using System;

namespace _13_practice
{

    //using System.Text.RegularExpressions;
    //public static string BreakCamelCase(string str) =>
    //new Regex("([A-Z])").Replace(str, " $1");   a better solution made by someone using regex..

//###############################################################################################################

    //Complete the solution so that the function will break up camel casing, using a space between words.
    //Example:
    //"camelCasing"  =>  "camel Casing"
    //"identifier"   =>  "identifier"
    //""             =>  ""
    class Program
    {
        static void Main(string[] args)
        {       
            string str = "";
           int slength = str.Length;
           string newstr = str;
            bool result;
            int count=0;
            char charis;
            while(count <slength){ 
                   if(count==slength){break;
                }         
              
                result = Char.IsUpper(newstr,count);
                charis = newstr[count];  
                if(count !=0&&result){ newstr = newstr.Insert(count," ");count+=1;slength+=1;}
               

                  Console.WriteLine("Index is: "+count+"\t Char of string is: "+charis +"\t Is Upper: " +result+"\t result:"+newstr);
                    
                count++;
              
            
              
            }
               Console.WriteLine("final string:\t"+newstr);
           

        
        }
    }
}
