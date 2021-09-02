using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class EquationObjectList
    {
        public static string Equation(DateTime birthday)
        {
            var year = DateTime.UtcNow.Year - birthday.Year;
            var month = DateTime.UtcNow.Month > birthday.Month ? DateTime.UtcNow.Month - birthday.Month : birthday.Month - DateTime.UtcNow.Month ;
            var days = DateTime.DaysInMonth(birthday.Year,birthday.Month)+ DateTime.UtcNow.Day - birthday.Day;

           
            return $"Peter is {year} years, {month-1} months and {days} days old";
        }




        static void Main(string[] args)
        {
            DateTime date = new DateTime(1983, 09, 21);
              Console.Write(Equation(date));
            Console.ReadKey();
        }
    }
}
