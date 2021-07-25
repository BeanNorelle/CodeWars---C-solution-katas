using System;
using System.Linq;

namespace _155_SmallestPermutations2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinPermutation(-3024));
        }

        public static int MinPermutation(int n)
        {
            bool IsNegative = false;
            if(n<0){ n*=-1; IsNegative=true;}

            Char [] CharArray = Convert.ToString(n).ToCharArray();
            Array.Sort(CharArray);

            return (IsNegative) ?  GetNumber(CharArray)*-1 : GetNumber(CharArray);    
        }

        public static int GetNumber(char[] arr)
        {
            if(arr[0]=='0')
            {
                for(int i =1;i<arr.Length;i++)
                {
                    if(arr[i]!='0')
                    {
                            arr[0] = arr[i];
                            arr[i]= '0';
                            break;
                    } 
                } 
            }    
         return Int32.Parse(arr);
        }
    }
}
