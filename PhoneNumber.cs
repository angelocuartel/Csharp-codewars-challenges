using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return string.Join(string.Empty, numbers).Insert(0,"(").Insert(4,") ").Insert(9,"-");
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Console.ReadKey();
        }
    }
}
