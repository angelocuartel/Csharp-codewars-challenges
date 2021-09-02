using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Temperature
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Get_Nearest_To_Zero(34,6,15,22));
            Console.ReadKey();
        }



        static int Get_Nearest_To_Zero(params int[] temps)
        {
            var nums = temps.OrderBy(i => i).ToArray();
            return nums[0] + nums[1] == 0 ? (nums[0] > nums[1] ? nums[0] : nums[1]) : nums[0];
        }


        static int Test(params int[] temps)
        {

            return 0;
        }


        
    }
}
