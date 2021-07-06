using System;
using System.Linq;

namespace _89_NextBiggerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextBiggerNumber2(1234567890));


        }
         public static long NextBiggerNumber(long n)
            {
                char [] arr = n.ToString().ToCharArray();
                char temp; long max =n; int convNum = 0;

        bool b = false;
        int num = arr[0];
        if(arr.Length==0&&b){return 0;}
                for(int i=arr.Length-1; i>0;i--){
     //               if(int.Parse(Convert.ToString(arr[i]))!=0){

                    temp = arr[i];
                    arr[i] = arr[i-1];
                    arr[i-1] =temp;

                            new string(arr);
                            convNum = Int32.Parse(arr);    

                    if(convNum>max){ max = convNum; b =true; break;} 

                                                arr = n.ToString().ToCharArray();
                    }
       //         }

                return max;
            }


            public static long NextBiggerNumber2(long n)
            {
            
              int[] arr = n.ToString().ToCharArray().Select(ch => (int) Char.GetNumericValue(ch)).ToArray();
                int i = arr.Length - 2;

                while (i >= 0 && arr[i + 1] <= arr[i]) {
                    i--;
                }
                
                if (i >= 0) { int j = i + 1;
                    while (j < arr.Length - 1 && arr[j + 1] > arr[i]) {
                    j++;
                    }
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;

                    Array.Reverse(arr, i + 1, arr.Length - i - 1);
                
                            return Int64.Parse(String.Concat(arr));
                    
                    } 
                    else 
                    {
                    return -1;
                    }

            }
    }

}