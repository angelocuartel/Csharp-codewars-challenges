using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Digits
    {
        static long DigPow(long n, int p)
        {
            string numbers = n.ToString();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += (int)Math.Pow(int.Parse(numbers.Substring(i, 1)), p + i);
            }
            int k = -1;
            int j = 0;
            while (true)
            {
                if (sum == (n * j))
                {
                    k = j;
                    break;
                }
                else if ((n * j) > sum)
                {
                    k = -1;
                    break;
                }
                j++;
            }

            return k;
        }
       static void Main(string[] args)
        {
            Console.Write(DigPow(454353453434,3));
            Console.ReadKey();
        }
    }
}
