using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class PyramidArray
    {
      

        static void Main(string[] args)
        {
            int[][] pyramid = new int[3][];
            for (int i = 0; i < pyramid.GetLength(0); i++)
            {
                pyramid[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                {

                    pyramid[i][j] = 1;
                }
            }
            Console.Write(Convert.ToInt32(pyramid[0][0]));
            Console.ReadKey();

            
        }
    }
}
