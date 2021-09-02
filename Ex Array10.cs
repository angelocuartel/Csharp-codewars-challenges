using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Array10
    {
        public static void Array10()
        {
            int[] array = { 213, 4, 56, 5, 65, 21, 5, 1345, 786, 4, 4, 4 };
            int numEqual = 1, finalNumEqual = 0, number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j + 1])
                    {
                        numEqual += 1;
                        if (finalNumEqual < numEqual)
                        {
                            finalNumEqual = numEqual;
                            number = array[i];
                        }
                    }
                    else
                    {
                        numEqual = 1;
                    }
                }
            }


            Console.WriteLine(@"integer that has most frequently occuring
Integer:{0}
{1} times", number, finalNumEqual);

            Console.ReadKey();
        }
    }
}
