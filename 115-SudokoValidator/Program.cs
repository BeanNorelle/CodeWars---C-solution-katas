using System;
using System.Linq;
using System.Collections.Generic;

namespace _115_SudokoValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] SudokyBoard = {
           new int [] {1, 2, 3, 4, 5, 6, 7, 8, 9},
           new int [] {2, 3, 1, 5, 6, 4, 8, 9, 7},
           new int [] {3, 1, 2, 6, 4, 5, 9, 7, 8},
           new int [] {4, 5, 6, 7, 8, 9, 1, 2, 3},
           new int [] {5, 6, 4, 8, 9, 7, 2, 3, 1},
           new int [] {6, 4, 5, 9, 7, 8, 3, 1, 2},
           new int [] {7, 8, 9, 1, 2, 3, 4, 5, 6},
           new int [] {8, 9, 7, 2, 3, 1, 5, 6, 4},
           new int [] {9, 7, 8, 3, 1, 2, 6, 4, 5}};

           Console.WriteLine(ValidateSolution(SudokyBoard));

        }
        

         public static bool ValidateSolution(int[][] board)
        {

            if(!ContainZero(board)) return false;

            if(!BoardBlocks(board)) return false;

            if(!CompleteBoard(board)) return false;

            return true;

        }

        public static bool ContainZero(int[][] board)
        {

            for(int column=0;column<board.Length;column++)
            {
                for(int row = 0; row<board.Length;row++)
                {
                    if(board[row][column]==0){return false;}
                }
            }
        
            return true;
        }

        public static bool BoardBlocks(int [][] board)
        {

        int[] nineNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
         for(int i =0;i<9;i++)
         {
            var Block = new List<int>();

            int br = (i / 3) * 3;
            int bc = (i % 3) * 3;

            for (int j = 0; j < 9; ++j)
            {
            Block.Add(board[br + j / 3][bc + j % 3]);
            }
            if (!nineNumbers.All(Block.Contains)) return false;
         }

        return true;
        }



          public static bool CompleteBoard(int[][] board)
        {  
            for(int column=0;column<board.Length;column++)
            {
                 int rowSum = 0; int columnSum = 0;
                for(int row = 0; row<board.Length;row++)
                {   
                    rowSum += board[row][column];
                    columnSum +=board[column][row];
                }

              if(rowSum!=45||columnSum!=45) return false;
            }     


            return true;
        }
    }
}
