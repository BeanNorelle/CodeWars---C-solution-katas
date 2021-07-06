using System;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _127_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {   
            Stopwatch sw = new Stopwatch();
            double sTime = 0;
            double fTime = 0; double dTime = 0;
            int n =100;
            
            sw.Start();
              sTime = sw.Elapsed.TotalMilliseconds;
              GetFizzBuzzArray(n);
              fTime = sw.Elapsed.TotalMilliseconds;
              dTime = fTime - sTime;
              Console.WriteLine("Elapsed time is : {0}",dTime);

            fTime = 0; sTime =0; dTime = 0;
              sTime = sw.Elapsed.TotalMilliseconds;
              GetFizzBuzzLinq(n);
              fTime = sw.Elapsed.TotalMilliseconds;
              dTime = fTime - sTime;
              Console.WriteLine("Elapsed time is : {0}",dTime);
            sw.Stop();
      
        }

        public static string[] GetFizzBuzzArray(int n)
        {
            string [] strArr = new string[n];
            string s = "";

           for(int i = 0;i <n;i++)
           {    s = "";
            
               if((i+1)%3==0)  
               s = "fizz";
               
               if((i+1)%5==0){s += "buzz";}

               if(((i+1)%5!=0 && (i+1)%3!=0)){s = Convert.ToString(i+1);}

               strArr[i]= s;          
           }

        return strArr;
        }
        public static string [] GetFizzBuzzLinq(int n)
        {
            //    return n > 0
            //     ? Enumerable.Range(1, n)
            //         .Select(x => x % 15 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}")
            //         .ToArray()
            //     : throw new ArgumentOutOfRangeException();      

                return (n > 0) ? Enumerable.Range(1,n)
                .Select(x => (x % 15 == 0) ? "FizzBuzz" : (x % 3 ==0) ? "Fizz" : (x % 5 == 0) ? "Buzz" : $"{x}")
                .ToArray() : throw new ArgumentOutOfRangeException();
        }
        
    }
}
