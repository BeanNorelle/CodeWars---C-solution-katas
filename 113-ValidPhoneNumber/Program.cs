using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;

namespace _113_ValidPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Console.WriteLine(ValidPhoneNumber4("(123) 456-7890"));
            sw.Stop();

            Console.WriteLine("Elapsed time {0}ms:", sw.Elapsed.TotalMilliseconds);
        }
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            char[] strCh = phoneNumber.ToCharArray();
            Console.WriteLine(strCh.Length);
            int sLength = strCh.Length;

            if(sLength>14||sLength<14) return false;

            for(int i = 0; i<sLength; i++)
            {
                if(i==0&&strCh[0]!='(')                   return false;
                if(i>=1&&i<=3&&!Char.IsDigit(strCh[i]))   return false;
                if(i==5&&strCh[5]!=' ')                   return false;
                if(i>=6&&i<=8&&!Char.IsDigit(strCh[i]))   return false;
                if(i==9&&strCh[9]!='-')                   return false;
                if(i>=10&&i<=13&&!Char.IsDigit(strCh[i])) return false;
            }

            return true;
        }


         public static bool ValidPhoneNumber2(string phoneNumber)
            {
                return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}\z");
            }
            
         public static bool ValidPhoneNumber3(string phoneNumber)
         {
            char[] strCh = phoneNumber.ToCharArray();
            int sLength = strCh.Length; 
            if(sLength!=14) return false;

            for(int i = 0 ; i<sLength; i++)
            {
                switch(i)
                {
                    case 0: if(strCh[i]!='(') return false; break;
                    case 1: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 2: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 3: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 4: if(strCh[i]!=')') return false;break;
                    case 5: if(strCh[i]!=' ') return false;break;
                    case 6: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 7: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 8: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 9: if(strCh[i]!='-') return false;break;
                    case 10: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 11: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 12: if(!Char.IsDigit(strCh[i])) return false;break;
                    case 13: if(!Char.IsDigit(strCh[i])) return false;break;
                    default: break;
                }
            }


            return true;
         }

          public static bool ValidPhoneNumber4(string Number)
            {
                if(Number.Length!=14 
                || Number[0]!='(' 
                || Number[4]!=')' 
                || Number[9]!='-' 
                || Char.IsWhiteSpace(Number[5])==false ) return false;
                for(int i=1;i<=3;i++)
                {
                char[] ar=new char[0];
                if(i==1) ar=Number.Substring(1,3).ToCharArray();
                else if(i==2) ar=Number.Substring(6,3).ToCharArray();
                else ar=Number.Substring(10,4).ToCharArray();
                
                if(ar.All(x=>Char.IsNumber(x))==false) return false;
                }
                return true;
            }


    }
}
