using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ExObject2
    {
        static void Main(string [] args)
        {
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(rand.Next(100, 200));
            }
            Console.ReadKey();
        }
    }
}
