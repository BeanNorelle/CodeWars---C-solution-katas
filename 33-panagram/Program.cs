using System;
using System.Linq;
using System.Collections.Generic;

namespace _33_panagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="The quick brown fox jumps over the lazy dog";
            str = String.Concat(str.Where(char.IsLetter)).ToLower();
            var newstr = string.Join("",str.ToCharArray().Distinct());
            int numAlpha = 0;
            bool res;

            foreach(var alpha in newstr){
                numAlpha += Math.Abs(alpha);
            }

            if(numAlpha == 2847){
                res = true;
            }
            else
            res = false;
         


            Console.Write(res);
        }
    }
}
