using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Methods2
    {
        static int GetMax( int[] num)
        {
            int tempHolder = 0;

            for (int count = 0; count < num.Length; count++)
            {
               if (num[count] > tempHolder)
                {
                tempHolder = num[count];
                }

            }

            return tempHolder;
        }

            static void Input(int[] inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                inputs[i] = int.Parse(Console.ReadLine());

            }
        }


        static void Main(string [] args)
        {
            int[] input = new int[3];
            Input(input);
            Console.WriteLine("the Biggest number is :{0}",GetMax(input));
            Console.ReadKey();

        }
    }
}
