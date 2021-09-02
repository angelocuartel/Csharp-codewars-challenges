using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class MultiplicationTable
    {
        public static void Table(int size)
        {
            int[,] table = new int[size, size];

            for (int r = 0; r < table.GetLength(0); r++)
            {
                for (int c = 0; c < table.GetLength(1); c++)
                {
                    table[r, c] = (r + 1) * (c + 1);
                }
            }

           for(int i = 0; i < table.GetLength(0);i++)
            {
                for(int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Table(3);
            Console.ReadKey();
        }
    }
}
