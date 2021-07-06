using System;

namespace _86_createPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            Console.WriteLine(CreatePhoneNumber(arr));
        }
          public static string CreatePhoneNumber(int[] numbers)
            {
                string phone = "";
                for(int i =0;i<numbers.Length;i++){
                   if(phone == "") 
                            phone +="(";
                    if(i<3){
                      phone += numbers[i];}
                    if( i == 3 ){ phone += ") ";}
                    
                    if( i>=3 && i<6 ){
                        phone += numbers[i];
                    }  
                    if(i==6){phone+= "-"+numbers[i];}
                    if(i>6) {phone += numbers[i]; }

                    
                   
                }

                return phone;
            }
    }
}
