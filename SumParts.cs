using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SumParts
    {

        static void GetArraySums(int[]ls)
        {
            /* long[] allSums = new long[ls.Length + 1];

             for (int i = 0; i < allSums.Length - 1; i++)
                 for (int j = i; j < ls.Length; j++) allSums[i] += (long)ls[j];

             allSums[allSums.Length - 1] = (long)0;

             return allSums;


            int sum = 0;
            int minus = 0;
            for (int i = 0; i < ls.Length; i++) sum += ls[i];
            int[] numbers = new int[ls.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++) minus += ls[j];
                numbers[i] = sum - minus;
            }*/
           
        }

        static void Main(string[] args)
        {
            int[] ls = { 0, 1, 3, 6, 10 };
            int sum = 0;
            int minus = 0;
            for (int i = 0; i < ls.Length; i++) sum += ls[i];
            int[] numbers = new int[ls.Length+1];
            numbers[0] = sum;
               for (int i = 1; i < numbers.Length; i++)
                {

                    for (int j = i-1; j < i; j++)
                    {
                        if (j == ls.Length) break;
                        minus += ls[j];
                    }
                    numbers[i] = sum - minus;
                }
            Console.ReadKey();
        }
    }
}
