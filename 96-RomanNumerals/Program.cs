using System;

namespace _96_RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("MDCLXVI"));
        }
        	public static int Solution(string roman)
            {
                int [] romanArr = {1,5,10,50,100,500,1000};
                char [] numArr = {'I','V','X','L','C','D','M'};
                int numCh = 0; int romanSum = 0; int prevNum = 0;
                Char[] charRoman = roman.ToCharArray();
                int count=0;
                    foreach(var s in charRoman){

                        var Index = Array.IndexOf(numArr,s);
                        numCh = romanArr[Index];
                        count++;
         

                            if(charRoman.Length == 1)
                                return numCh;

                            if(prevNum>=numCh&&prevNum!=0)
                               romanSum +=numCh; 
                                 
                            if(prevNum<numCh){
                            Console.WriteLine(prevNum+ " "+numCh);
                                romanSum+= Math.Abs((prevNum*2)-numCh);}

                               prevNum = numCh;  
                                                                                          
                               
                    }
                      

               return romanSum;
            }
    }
}
