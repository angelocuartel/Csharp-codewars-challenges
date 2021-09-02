using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StringRotation
    {
        public static int ShiftedDiff(string first, string second)
        {
            var equals = first;

            int i = 0;

            while (true && first != second)
            {


                first = first = (first.Insert(0, first.Substring(first.Length - 1, 1))).Remove(first.Length, 1);

                if (equals == first)
                {
                    i = -1;
                    break;

                }
                else if(first == second)
                {
                    i+=1;
                    break;             
                }


                i++;

            }

            return i;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ShiftedDiff("coffee","eecoff"));
            Console.ReadKey();
        }
    }
}
