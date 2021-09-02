using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    static class Fibonacci
    {


        static void PrintFibbo( int length)
        {
            var nums = new int[] { 0, 1, 0 };

            for(int i = 0; i < length-1; i++)
            {
                if (i > 0)
                {
                    nums[2] = nums[0] + nums[1];
                    nums[0] = nums[1];
                    nums[1] = nums[2];
                    Console.WriteLine(nums[2]);
                }

                else
                {
                    Console.WriteLine("0\n1");
                }
            }
        }
        public static void Main(string[] args)
        {
            PrintFibbo(10);
            Console.ReadKey();

        }
    }
}
