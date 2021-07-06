using System;
using System.Diagnostics;

namespace _63_darray
{
    class Program
    {
        static void Main(string[] args)
        {   
        int row = 6;
        int columns = 12; 
        Stopwatch sw = new Stopwatch();
        sw.Start();
         char[][] cb = ChessBoard(row,columns);

                for(int i=0;i<row;i++){
                    for(int j=0;j<columns;j++){
                        Console.Write(cb[i][j]);
                    }
                    Console.WriteLine("");
                }
           sw.Stop();
        Console.WriteLine("Elapsed {0}ms", sw.Elapsed.TotalMilliseconds);
        Console.ReadKey();
        }
        public static char[][] ChessBoard(int row, int columns){

             char[][] chessBoard = new char[row][];
             for(int i=0;i<row;i++){
                  chessBoard[i] = new char[columns];               
                 for(int j=0;j<columns;j++){                        
                     chessBoard[i][j] = ((i+j&1)==1) ? 'X':'0';
                 }
             }
             return chessBoard;
        }

      

    }
}
