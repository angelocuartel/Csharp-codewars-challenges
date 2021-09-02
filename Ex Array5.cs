using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Array5
    {
        public static void Array5()
        {
            int[] array = { 23, 65, 23, 1, 4, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8 };

            int numEqual = 1, numSequence = 0;
            int finalNumEqual = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {

                if ((array[i] - array[i + 1]) == -1)
                {
                    numEqual += 1;

                    if (numEqual > finalNumEqual)
                    {
                        finalNumEqual = numEqual;
                    }
                    if (numSequence == 0)
                    {
                        numSequence = array[i];
                    }

                }
                else
                {
                    numEqual = 1;
                    numSequence = 0;
                }


            }

            for (int i = 1; i <= finalNumEqual; i++)
            {
                Console.Write((numSequence - 1) + i + " ");
            }


            Console.ReadKey();
        }
    }
}
