using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class GarbleSort
    {

        public static int[] Sort(int[] values)
        {
            int[] garble = { 7, 9, 6, 4, 1, 3, 5, 8, 2 };
            int[] answer = new int[values.Length];

            int index = 0;
            for(int i = 0; i < garble.Length; i++)
            {
                for(int j = 0; j  < values.Length; j++)
                {
                    if(garble[i] == values[j])
                    {
                        answer[index] = garble[i];
                        index++;
                    }
                }

                if (index > values.Length)
                {
                    break;
                }
            }

            return answer;
            
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Sort(new int[] { 1, 2, 3 }));
            Console.ReadKey();
        }
    }
}
