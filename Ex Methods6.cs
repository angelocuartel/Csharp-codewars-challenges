using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Methods6
    {
        /*Write a method that returns the position of the first occurrence of an
element from an array, such that it is greater than its two neighbors
simultaneously. Otherwise the result must be -1.*/
        public static int ArrayPosition(params int[] array)
        {
            int largeVal = 0, finalLargeVal = 0;
            Console.WriteLine("Position/s Occurence:\n");
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i + 1] > array[i] && array[i + 1] > array[i + 2])
                {
                    largeVal = array[i + 1];
                    Console.WriteLine("Position {0}",(i+1)+1);
                    if (largeVal > finalLargeVal)
                    {
                        finalLargeVal = largeVal;
                    }
                }
            }

            return finalLargeVal;

        }


        static void Main(string [] args)
        {
            Console.WriteLine("Largest Value:{0}", ArrayPosition(12,564,213,334,65,123,7667,12,765,43,2));
            Console.ReadKey();
        }
    }
}

