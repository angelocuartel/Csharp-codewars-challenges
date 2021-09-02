using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class PascalTriangle2
    {

        public static void GetPascal(int n)
        {

            var numbers = new int[n][];


            for (int i = 0; i < n; i++)
            {
                numbers[i] = new int[i + 1];

                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (j == 0 || j == i)
                    {
                        numbers[i][j] = 1;
                    }
                    else
                    {
                        numbers[i][j] = numbers[i - 1][j-1] + numbers[i - 1][j];
                    }
                }
            }

            return numbers;


           foreach(Array item in numbers)
            {
                foreach (int item2 in item) Console.Write(item2 + " ");
                Console.WriteLine();
            }


        }


        static void Main(string[] args)
        {
            GetPascal(10);
            Console.ReadKey();
        }
    }
}
