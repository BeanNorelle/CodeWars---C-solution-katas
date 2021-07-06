using System;
using System.Collections.Generic;

namespace _111_parseInt
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ParseInt("two million one hundred twenty one thousand nine hundred twenty one"));
        }

        public static int ParseInt(string s)
        {
            string InitString = s.ToLower();
            
        Dictionary<int,string> ParseIntDictionary = new Dictionary<int, string>(){
            {1,"one"}, {2,"two"},{3,"three"},{4,"four"},{5,"five"},{6,"six"},{7,"seven"},{8,"eight"},{9,"nine"},{10,"ten"},
            {11,"eleven"},{12,"twelve"},{13,"thirteen"},{14,"fourteen"},{15,"fifteen"},{16,"sixteen"},{17,"seventeen"},{18,"eighteen"},{19,"nineteen"},
            {20,"twenty"},{30,"thirty"},{40,"fourty"},{50,"fifty"},{60,"sixty"},{70,"seventy"},{80,"eighty"},{90,"ninety"},
            {100,"hundred"},{1000,"thousand"},{1000000,"million"}};
            
            string[] strArr = InitString.Split(' ','-');
            int keyD = 0; int result = 0; int multiplier = 1;

            for(int i = strArr.Length-1;i>=0;i--)
            {
               keyD =  KeyByValue(ParseIntDictionary, strArr[i]);  
              //  Console.WriteLine(keyD);

                if(keyD>=100)
                    if(multiplier<keyD)
                    multiplier = keyD;
                    else 
                    multiplier *=keyD;
                if(keyD<100)
                    result+=keyD * multiplier;          
                    
            }

            return result;
       
        }
        public static T KeyByValue<T, W>(this Dictionary<T, W> dict, W val)
        {
            T key = default;
            foreach (KeyValuePair<T, W> pair in dict)
            {
                if (EqualityComparer<W>.Default.Equals(pair.Value, val))
                {
                    key = pair.Key;
                    break;
                }
            }
            return key;
        }


    }
}
