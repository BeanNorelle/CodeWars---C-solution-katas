using System;
using System.Collections.Generic;

namespace _64_staorsquare
{
    class Program
    {
        static void Main(string[] args)
        {
            
                char[,]tablet = new char[4,4]{{'a','s','s','d'},
                            {'s','o','o','s'},
                            {'s','o','o','s'},
                            {'d','s','s','a'}};

                          Console.WriteLine(IsSatorSquare(tablet));
        }

    public static bool IsSatorSquare(char[,] tablet)
    {
      int middle = tablet.GetLength(0) / 2;
      int len = tablet.GetLength(0) - 1;
      
      for (int i = 0 ; i <= middle ; i ++) 
        for (int j = i ; j <= len ; j ++){ 
          if (tablet[i, j] != tablet[j, i]
            || tablet[i, j] != tablet[len - i, len - j]
            || tablet[i, j] != tablet[len - j, len - i])
               
            return false;
        }
      return true;
    }
  }
}
