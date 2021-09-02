using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SortedArrays
    {

        public static int NthSmallest(int[][] arr, int n)
        {

            List<int> numbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
         for (int j = 0; j <arr[i].Length ; j++)numbers.Add(arr[i][j]);

            int[] sorted = numbers.ToArray();
            Array.Sort(sorted);


            return sorted[n-1];
         
        }


        static void Main(string[] args)
        {
           Console.Write(NthSmallest(new int[][] { new int[] { 1, 5 }, new int[] { 2 }, new int[] { 4, 8, 9 } }, 4));
            Console.ReadKey();
        }
    }
}
