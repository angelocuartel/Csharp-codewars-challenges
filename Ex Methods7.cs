using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Methods7
    {
        private static int DigitReverse(int input)
        {
            string rev = Convert.ToString(input);
            string finalRev = "";
            for (int i = 0; i < rev.Length; i++)
            {
                finalRev += rev.Substring((rev.Length - 1)-i, 1);
            }
            return int.Parse(finalRev);
        }


        static void Main(string [] args)
        {
            Console.WriteLine("Enter a number: ");
            int input =Convert.ToInt32(Console.ReadLine());

            Console.Write("Original Digit: {0} \nReverse Digit: {1}", input, DigitReverse(input));
            Console.ReadKey();
        }
    }
}
