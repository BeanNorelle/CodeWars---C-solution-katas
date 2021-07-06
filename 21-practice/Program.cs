using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _21_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "A a aa b";
            string[] strings = Regex.Split(s, @"\W|_");
            var count = strings.Count();
            char a =  s[1];
            int str = 0;
             int intword = 0;
             int index=0;
                   string finalstr = "";
                   string exstr = "";
                int max=0;
            for(int i=0;i<=count-1;i++){
                int strlength = (strings[i]).Length;
                Console.Write("\t");
                intword = 0;
          
                for(int j=0;j<=strlength-1;j++){
                            char ab = ((strings[i])[j]);
                            str = (int)ab%32;
                            intword = str + intword;
                }
                if(intword>max){
                    max =intword;
                    if(index != i){
                    finalstr = strings[i];
                    index = Array.IndexOf(strings,finalstr);
                    }

                }               
            }
            Console.WriteLine(max+"\t"+finalstr+"\t"+index);
        }
    }
}
