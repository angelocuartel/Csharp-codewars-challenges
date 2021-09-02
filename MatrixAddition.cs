using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class MatrixAddition
    {
        public static int[][] GetAdd(int[][] a, int[][] b)
        {
            int[][] answers = new int[a.GetLength(0)][];
            for (int i = 0; i < answers.GetLength(0); i++) answers[i] = new int[a.GetLength(0)];

         for(int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++) answers[row][col] = a[row][col] + b[row][col];
            }

            return answers;

        }


        static void Main(string[] args)
        {
           
        }
    }
}
