using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ArrayLeaders
    {
        public static int[] GetAllSum(int[] numbers)
        {
            List<int> answer = new List<int>();
            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)

            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                }

                Console.WriteLine(i+" "+sum);

                if (numbers[i] > sum)
                {
                    answer.Add(numbers[i]);
                }
                sum = 0;
            }

            if (numbers[numbers.Length - 1] > 0) answer.Add(numbers[numbers.Length - 1]);

            return answer.ToArray();

        }
        static void Main(string[] args)
        {
            GetAllSum(new int[] { -1, -29, -26, -2 });
            Console.ReadKey();
        }
    }
}
