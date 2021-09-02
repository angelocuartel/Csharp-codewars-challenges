using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Array6
    {
        public static void Array6()
        {
            int[] array = { 43, 23, 45, 12, 47, 32, 49, 34, 51, 36, 53, 38, 55, 40, 57, 42, 59, 44, 61, 46 };

            int numEqual = 1, numSequence1 = 0,
            numSequence2 = 0;
            int finalNumEqual1 = 0, finalNumEqual2 = 0;

            for (int i = 1; i < array.Length - 2; i += 2)
            {

                if ((array[i] - array[i + 2]) == -2)
                {
                    numEqual += 1;

                    if (numEqual > finalNumEqual2)
                    {
                        finalNumEqual2 = numEqual;
                    }
                    if (numSequence2 == 0)
                    {
                        numSequence2 = array[i];
                    }

                }
                else
                {
                    numEqual = 1;

                }

            }

            numEqual = 1;

            for (int i = 0; i < array.Length - 2; i += 2)
            {

                if ((array[i] - array[i + 2]) == -2)
                {
                    numEqual += 1;

                    if (numEqual > finalNumEqual1)
                    {
                        finalNumEqual1 = numEqual;
                    }
                    if (numSequence1 == 0)
                    {
                        numSequence1 = array[i];
                    }

                }
                else
                {
                    numEqual = 1;

                }

            }

            if (finalNumEqual1 > finalNumEqual2)
            {

                for (int i = 2; i <= (finalNumEqual1 + finalNumEqual1); i += 2)
                {
                    Console.WriteLine("{0}", (numSequence1 - 2) + i);
                }

            }
            else
            {
                for (int i = 2; i <= (finalNumEqual2 + finalNumEqual2); i += 2)
                {
                    Console.WriteLine("{0}", (numSequence2 - 2) + i);
                }
            }





            Console.ReadKey();
        }
    }
}
