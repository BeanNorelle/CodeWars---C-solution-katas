using System;
using System.Text;
using System.Linq;

namespace _123_SpinningWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinLinq("Hey fellow warriors"));
        }

        public static string SpinWords(string sentence)
        {  
             string reverse ="";
            
            string[] strArr = sentence.Split(" ");
            int sLength = strArr.Length;
            string [] SpunWords = new string[sLength];

            for(int i =0;i<strArr.Length;i++)
            {   
                reverse ="";
                if(strArr[i].Length>=5)
                {                   
                     char [] strCh = strArr[i].ToCharArray();
                     for(int j = strCh.Length-1;j>=0;j--)
                     {
                         reverse+=(strCh[j]);
                     }
                }
                else
                {
                    reverse=strArr[i];
                }
            
            SpunWords[i] = reverse;
            }
            return String.Join(" ",SpunWords);
        }

        public static string SpinLinq(string sentence)
        {
             // String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));

        return String.Join(" ",
               sentence.Split(' ')
               .Select (str=> str.Length >4 ? new string(str.Reverse().ToArray()) : str));

   
        }
    }
}
