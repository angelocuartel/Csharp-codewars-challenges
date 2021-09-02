using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class NumOfTrailingZeroes
    {
        public static int CountZeroes(int n)
        {

            var num1 = 5;

            var count = 2;
            var answer = 0;
    
            while (n >= num1)
            {

                answer += (n / num1);

                num1 = (int) Math.Pow(5, count);
                count++;
                
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(CountZeroes(5));
            Console.ReadKey();
        }
    }
}
