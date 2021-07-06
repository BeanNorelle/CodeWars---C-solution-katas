using System;
using System.Linq;

namespace _90_playingWithDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digPow(89,1));
        }
        public static long digPow(int n, int p) {
            int []arr = n.ToString().ToCharArray().Select(ch=> (int) Char.GetNumericValue(ch)).ToArray();
            long lSum = 0; long divi = 0;

            for(int i=0;i<arr.Length;i++){
              lSum += (long)Math.Pow(arr[i],p+i);
            }
            divi = lSum/n; 
            return (lSum == divi*n)? divi : -1;
	    }
    }
}
