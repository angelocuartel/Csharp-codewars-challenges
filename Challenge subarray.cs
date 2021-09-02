using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class subarray
    {
      public static int[] array = { 23, 45, 12, 76, 23 };
        static void Main(string [] args)
        {

            for(int i = 0; i < array.Length; i++)
            {
                Loop(i);
               
            }

            Console.ReadKey();
        }




        public static void Loop(int input)
        {

            for (int i = 1; i <= array.GetLength(0); i++)
            {
                for (int j  = input; j < i; j++)
                {

                    Console.Write(array[j] + " ");
                }
                Console.WriteLine();

            }
        }
    }


}
