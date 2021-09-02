using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Methods9
    {
      private static int LargeValue(int[]array)
        {
            int temp = 0;
            for(int i = 0; i< array.Length-1; i++)
            {
                if(array[i] > array[i + 1])
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }

            return array[array.Length - 1];
        }

        static void Main(string [] args)
        {
            Console.Write("Enter array Length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numArr = new int[length];
            for(int i = 0; i < numArr.Length; i++)
            {
                Console.Write("Enter array element({0}): ", i + 1);
                numArr[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.Write("largest Array value: {0}",LargeValue(numArr));
            Console.ReadKey();
        }
    }
}
