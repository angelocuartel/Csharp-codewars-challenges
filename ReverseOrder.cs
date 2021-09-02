using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ReverseOrder
    {
        public static List<int> ReverseList(List<int> list)
        {
            List<int> numbers = new List<int>();
            foreach (var item in list) numbers.Add(item);
            numbers.Reverse();
            return numbers;
        }

        static void Main(string[] args)
        {

            List<int> nums = new List<int>() { 12, 54, 23, 1 };
            Console.WriteLine(ReverseList(nums));
            Console.ReadKey();
        }
    }
}
