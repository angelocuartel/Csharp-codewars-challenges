using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ExObject1
    {
        static bool LeapYear(int year)
        {
            return (DateTime.IsLeapYear(year));
        }
        static void Main(string [] args)
        {
            Console.Write(LeapYear(1999));
            Console.ReadKey();
        }
    }
}
