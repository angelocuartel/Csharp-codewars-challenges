using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class TicTacToeChanger
    {
         int[,] board;
         int y, x;
        public int IsSolved(int[,] board)
        {
            y = x = 0;
            this.board = board;

            bool hasZero = false;

            for (int r = 0; r <3;r++)
            {
                for (int c = 0; c < 3; c++)
                { 
                    if (board[r, c] == 0)
                    {
                        hasZero = true;
                       
                    }
                    else if (r == 0 && c == 0)
                    {
                        CheckVertically(c);
                        CheckDiagonalForward();
                        CheckHorizontally(r);
                       
                    }
                    else if (r == 0 && c == 2)
                    {
                        CheckDiagonalBackward();
                        CheckVertically(c);
                      
                    }
                    else if (r > 0)
                    {
                        CheckHorizontally(c);
                        
                    }

                }

            
            }


            return x > y ? 2 : x < y ? 1 : hasZero ? -1 : 0;


        }

        private  void CheckVertically(int colIndex)
        {
            if (board[0, colIndex] == 1 && board[1, colIndex ] == 1 && board[2, colIndex] == 1) y++;
            else if (board[0, colIndex] == 2 && board[1, colIndex] == 2 && board[2, colIndex] == 2) x++;
        }


        private  void CheckDiagonalForward()
        {
            if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1) y++;
            else if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2)x++;
        }

        private void CheckDiagonalBackward()
        {
            if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 2] == 1) y++;
            else if(board[0, 2] == 2 && board[1, 1] == 2 && board[2, 2] == 2) x++;
        }


        private void CheckHorizontally(int rowCurrentIndex)
        {
            if (board[rowCurrentIndex, 0] == 1 && board[rowCurrentIndex , 1] == 1 && board[rowCurrentIndex, 2] == 1) y++;
            else if (board[rowCurrentIndex, 0] == 2 && board[rowCurrentIndex, 1] == 2 && board[rowCurrentIndex, 2] == 2) x++;
        }


        static void Main(string[] args)
        {
            var tictacToe = new TicTacToeChanger();

            Console.WriteLine(tictacToe.IsSolved(new int[,] { {0,2,2}, 
                                                              { 2,1,1} ,
                                                              { 0, 0, 1 } }));
            Console.ReadKey();
        }
    }
}
