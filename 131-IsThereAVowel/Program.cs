using System;

namespace _131_IsThereAVowel
{
    class Program
    {
        static void Main(string[] args)
        {   
            object [] vowels = { 118,117,120,121,117,98,122,97,120,106,104,116,113,114,113,120,106}; 
            foreach(var s in IsVow(vowels))
            {
                Console.Write(" "+ s);
            }
        
        }

         public static object[] IsVow(object[] a)
        {
            int aLength = a.Length;

            for(int i =0;i<aLength;i++)
            {
                switch(a[i])
                {
                    case 97:  a[i] =  (Convert.ToChar(a[i])); break;
                    case 101: a[i] =  (Convert.ToChar(a[i])); break;
                    case 105: a[i] =  (Convert.ToChar(a[i])); break;
                    case 111: a[i] =  (Convert.ToChar(a[i])); break;
                    case 117: a[i] =  (Convert.ToChar(a[i])); break;
                    default: break;
                }
            }

            return a;
        }
    }
}
