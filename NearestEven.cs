using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class NearestEven
    {
        public static int EnsureEven(double number)
        {
            double even = 0;
        
         if (number > 0)
                even = number % 2 == 0 ? number : number + 1;
            else if (number < 0)
                even = number % -2 == 0 ? number : number - 1;
          
            return (int)even;
        }

        static void Main(string[] args)
        {
            Console.Write(EnsureEven(183510));
            Console.ReadKey();
        }
    }
}
