using System;

namespace _94_ipValidation
{
    class Program
    {
        static void Main(string[] args)
        {  
                        string ss = "122.02.3.4";
         Console.WriteLine(is_valid_IP(ss));
     }
      public static bool is_valid_IP(string ipAddres)
        {
            var ipArray = ipAddres.Split('.');
          if(ipArray.Length!=4)return false;

          foreach(var s in ipArray){
             int result = 0;
              if (!int.TryParse(s, out result))
                return false;
                
              if (result == 0 && s.Length > 1)
                return false;
                
              if (s.Contains(" "))
                return false;
                
              if (s.StartsWith("0") && s.Length > 1)
                return false;
                
              if (result < 0 || result > 255)
                return false;
          }
            return true;              
        }
    }
}

