using System;

namespace _67_chessCellColor
{
    class Program
    {
        static void Main(string[] args)
        {  
            string bishop= "D3";
            string pawn= "B7";
                   Console.Write(ChessBoardCellColor(bishop,pawn));
        }
        public static bool ChessBoardCellColor(string cell1, string cell2){
               var x = (cell1[0]+cell1[1]);
                 var y = (cell2[0]+cell2[1]);
                    return ((x%2==0)==(y%2==0)) ? true : false;
        }
    }
}
