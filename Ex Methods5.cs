using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{/*Write a method that checks whether an element, from a certain position
in an array is greater than its two neighbors. Test whether the
method works correctly.*/
    class Ex_Methods5
    {
        public static int ChkTwoNeighboors(params int[] array)
        {
            int largeVal=0, finalLargeVal = 0;
            for(int i = 0; i < array.Length-2; i++)
            {
                if(array[i+1] > array[i] && array[i+1] > array[i + 2])
                {
                    largeVal = array[i + 1];
                    if(largeVal > finalLargeVal)
                    {
                        finalLargeVal = largeVal;
                    }
                }
            }

            return finalLargeVal;
        }

        static void Main(string [] args)
        {
            Console.WriteLine("largest value:{0}", ChkTwoNeighboors(12, 54, 123, 1000, 54,345,12,67,32,28));
            Console.ReadKey();
        }

    }
}
