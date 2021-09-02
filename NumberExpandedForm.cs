using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class NumberExpandedForm
    {
        public static string ExpandedForm(long num)
        {
            var numbers = num.ToString();
            StringBuilder newNumber = new StringBuilder();

            foreach(char number in numbers)
            {
                if (number != '0')
                {
                    newNumber.Append($" + {number}");
                    numbers = numbers.Remove(0, 1);
                    Console.WriteLine(numbers.Length + " " + number);
                    newNumber.Append('0', numbers.Length);
                }
                else numbers = numbers.Remove(0, 1);
            }

            return newNumber.ToString().Remove(0,3);
        }



    
        static void Main(string[] args)
        {
            Console.Write(ExpandedForm(70304));
            Console.ReadKey();
        }
}
}
