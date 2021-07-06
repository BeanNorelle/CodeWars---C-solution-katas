using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace _58_rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
                        string message = "OnCe UpOn A tImE yOu DrEsSeD sO fInE (1968)";
            sw.Start();
            Console.WriteLine(rot13(message,14));
            sw.Start(); Console.WriteLine("Time is {0}", sw.Elapsed.TotalMilliseconds);

            // sw.Start();
            // Console.WriteLine(playPass(message,14));
            // sw.Start(); Console.WriteLine("Time is {0}", sw.Elapsed.TotalMilliseconds);


        }
        public static string rot13(string message,int n){
           
            var lowerCase = Enumerable.Range('a', 'z' - 'a' + 1). Select(c => (char)c).ToList();
            string newMsg = message.ToLower();
            string words="";
            int toint =  0;
            bool digitCount = true;
            foreach(var ch in newMsg){
       
                    if(!Regex.IsMatch(ch.ToString(), "^[a-z]*$")){
                        if(Regex.IsMatch(ch.ToString(),"^[0-9]+$")){
                          int cint = (int)char.GetNumericValue(ch);
                         words+= (cint-10<-1) ? Convert.ToString((cint-9)*-1) : Convert.ToString(cint-9);
                        }
                          else{
                          words+=ch;}
                    }
                    else{
       
                    switch((digitCount) ? "ucase": "lcase"){
                    case "ucase": 
                    toint = lowerCase.IndexOf(ch);
                     words+= ((toint)+n>25) ? Convert.ToString(lowerCase[(((toint)+n)-26)]).ToUpper() : Convert.ToString(lowerCase[((toint)+n)]).ToUpper();
                    digitCount = false;
                    break;
                    case "lcase":
                    toint = lowerCase.IndexOf(ch);
                    words+= ((toint)+n>25) ? Convert.ToString(lowerCase[(((toint)+n)-26)]).ToLower() : Convert.ToString(lowerCase[((toint)+n)]).ToLower();
                    digitCount = true;
                      break;
                    }
                }
            }
              char[] charArray = words.ToCharArray();
                Array.Reverse( charArray );
                return new string( charArray );
        }


    public static string playPass(string s, int n) {
    var result = new StringBuilder(s.Length);
    
    for(int i = s.Length - 1; i >= 0; i--)
    {
      var ch = s[i];    
      if (ch >= 'A' && ch <= 'Z')  // Char.IsLetter
      {
        ch = (char)('A' + ((ch - 'A' + n) % 26));
        if ((i & 1) == 1) // odd
        { 
          ch = (char)(ch - 'A' + 'a'); // Char.ToLower
        }
        // to upper is not neccessary because input in uppercase
      }
      else if (ch >= '0' && ch <= '9') // Char.IsDigit
      {  
        ch = (char)('0' + '9' - ch);
      }
      // else put unchanged      
      result.Append(ch);
    }   
    return result.ToString();
  }
}

    }

