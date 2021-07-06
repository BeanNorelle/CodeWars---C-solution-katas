using System;

namespace _18_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int []arr = {101,3,42,51,52,56,9,99};
            int max1=0;
            int max2=0;

    
            for(int i =0;i<arr.Length;++i){

                    if(arr[i]>max1){
                            max2 = max1;
                            max1 = arr[i];
                    }
                    else
                    if(arr[i]>max2){
                            max2=arr[i];
                    }
              
            }

            int []arr2 = {max2,max1};
 
            Console.WriteLine("max1:"+max1+"\tmax2:"+max2);


        }
    }
}
