using System;
using System.Text;

namespace _61_passphrase
{
    class Program
    {
        static void Main(string[] args)
        {      
            string s = "hello";
            int n =3;
        
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
    
    //return result.ToString();
        }
    }
}
