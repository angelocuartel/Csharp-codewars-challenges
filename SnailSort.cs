using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SnailSort
    {

        static void Main(string[] args)
        {
            int?[][] snailNumbers =
            {
         new int?[] { }
            };

           
              int right = 0, down = 0, left = 0, up = 0, row = 0, col = 0, length = snailNumbers.GetLength(0),adder =0;
            if (snailNumbers[0].Length != 0)
            {
                int[] snailSort = new int[snailNumbers.Length * snailNumbers.Length];
                for (int index = 0; index < snailSort.Length; index++)
                {
                    if (right < length)
                    {
                        snailSort[index] = (int)snailNumbers[row][col];
                        right++;
                        col++;
                    }
                    else if (down < length - 1)
                    {
                        row++;
                        snailSort[index] = (int)snailNumbers[row][col - 1];
                        down++;
                    }
                    else if (down == length - 1 && left < length - 1)
                    {

                        col--;
                        snailSort[index] = (int)snailNumbers[row][col - 1];
                        left++;
                    }
                    else if (left == length - 1)
                    {
                        row--;
                        snailSort[index] = (int)snailNumbers[row][col - 1];
                        up++;
                        if (up == length - 2)
                        {
                            length -= 2;
                            adder++;
                            row = col = adder;
                            up = down = right = left = 0;
                        }
                    }

                }
                foreach (int number in snailSort) Console.Write(number + " ");
            }

            else
            {
                int[]snailSort = new int[0];
                Console.Write(snailSort);
            }
             
           

            Console.ReadKey();
        }
    }
}
