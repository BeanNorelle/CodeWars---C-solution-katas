using System;

namespace _101_PalindromeChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindromeChainLength(89));
        }
          public static int palindromeChainLength(int n) {
            // bool isPalin = false;
             UInt64 input = (UInt64)n; UInt64 sum = 0; int count = 0;
              while(!isPalin(input)){          
                sum = (input + reverse(input));     Console.WriteLine(count +"    "+input);
                input = sum; count++;
              }    
              return count;
          }

        public static UInt64 reverse(UInt64 n){
               UInt64 rem = 0; UInt64 reverse =0;
                  while(n!=0){
                    rem=(UInt64)n%10;        
                    reverse=reverse*10+rem;      
                     n/=10;    
                }   
            return reverse;
        }

        public static bool isPalin(UInt64 n){
             UInt64 num = (UInt64)n,r,sum=0;  
              while(num>0)      
                {      
                r=num%10;      
                sum=(sum*10)+r;      
                num=num/10;      
                }      
                return ((UInt64)n==sum) ? true : false;
        }
    }
}
