using System;
using System.Text;

namespace _106_RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToRoman(1000));
        }

        public static string ToRoman(int n)
        {  // bool isZero = false;
            int Result = n;
            StringBuilder sB = new StringBuilder();
            int div = 0;
 
            
            if(Result>= 1000){ div = Result/1000;  sB.Append('M',div); Result= Math.Abs(Result - 1000*div);} 

            if(Result>=900){ sB.Append('C',1); sB.Append('M',1); Result= Math.Abs(Result - 900);}

            if(Result>=500){sB.Append('D',1); Result = Math.Abs(Result - 500);}

            if(Result>=400){ sB.Append('C',1); sB.Append('D',1); Result = Math.Abs(Result - 400);}
            
             if(Result>=100){ div = Result/100; sB.Append('C',div); Result = Math.Abs(Result - 100*div);}

             if(Result>=90){ sB.Append('X',1);sB.Append('C',1); Result = Math.Abs(Result - 90);}

             if(Result>=50){ sB.Append('L',1); Result = Math.Abs(Result - 50);}

             if(Result>=40){ sB.Append('X',1);sB.Append('L',1); Result = Math.Abs(Result - 40);}
           
             if(Result>=10){ div = Result/10; sB.Append('X',div); Result = Math.Abs(Result - 10*div);}

             if(Result>=9){sB.Append('I',1); sB.Append('X',1); Result = Math.Abs(Result - 9);}

             if(Result>=5){sB.Append('V',1); Result = Math.Abs(Result-5);}

             if(Result>=4){sB.Append('I',1); sB.Append('V',1); Result = Math.Abs(Result-4);}

             if(Result>=1){ sB.Append('I',Result); Result = Math.Abs(Result-1*Result);}

            return sB.ToString();
        }
    }
}
