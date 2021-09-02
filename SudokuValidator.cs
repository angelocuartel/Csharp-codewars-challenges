using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SudokuValidator
    {

        public static bool ValidateSudoku(int[][]board)
        {
            bool isValidate = true,isStop = false;
            StringBuilder numRows = new StringBuilder();
            StringBuilder numCols = new StringBuilder();


            for (int rows = 0; rows < board.GetLength(0); rows++)
            {
                for (int cols = 0; cols < board.GetLength(0); cols++)
                {
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        numRows.Append(board[i][rows]);
                        numCols.Append(board[rows][i]);
                    }
                 

                    if ((cols == 0 && rows ==0) || (cols ==3 && rows ==3) ||(cols ==6 && rows ==6))
                    {
                        if (board[rows + 1][cols + 1] == board[rows][cols] || board[rows + 1][cols + 2] == board[rows][cols] || board[rows + 2][cols + 1] == board[rows][cols] || board[rows + 2][cols + 2] == board[rows][cols])
                        {
                            isStop = true;
                            isValidate = false;
                            break;
                        }
                    }

                    if (!numRows.ToString().Contains(board[rows][cols].ToString()) || !numCols.ToString().Contains(board[rows][cols].ToString()))
                    {
                        isStop = true;
                        isValidate = false;
                        break;
                    }

                    else
                    {
                        numRows.Clear();
                        numCols.Clear();
                    }
                }

                if (isStop) break;


             }

            return isValidate;


        }


        static void Main(string[] args)
        {
            Console.Write(ValidateSudoku(new int[][]
            {
       new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
new int[]{2, 3, 1, 5, 6, 4, 8, 9, 7},
new int[]{3, 1, 2, 6, 4, 5, 9, 7, 8},
new int[]{4, 5, 6, 7, 8, 9, 1, 2, 3},
new int[]{5, 6, 4, 8, 9, 7, 2, 3, 1},
new int[]{6, 4, 5, 9, 7, 8, 3, 1, 2},
new int[]{7, 8, 9, 1, 2, 3, 4, 5, 6},
new int[]{8, 9, 7, 2, 3, 1, 5, 6, 4},
new int[]{9, 7, 8, 3, 1, 2, 6, 4, 5}
        }));
            Console.ReadKey();
        }
    }
}
//if (rows != board.GetLength(0) - 2)
//{
//    if (board[rows + 1][cols + 1] == board[rows][cols] || board[rows + 1][cols + 2] == board[rows][cols] || board[rows + 2][cols + 1] == board[rows][cols] || board[rows + 2][cols + 2] == board[rows][cols])
//    {
//        Console.WriteLine(board[rows + 1][cols + 1]);
//        isStop = true;
//        isValidate = false;
//        break;
//    }
//}