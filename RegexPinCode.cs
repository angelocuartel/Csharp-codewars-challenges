using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TrainingGround
{
    class RegexPinCode
    {
        public static bool ValidatePin(string pin)
        {
       
            bool isValidate = false;
            Regex pinCode6 = new Regex("^[1-9]{6}$");
            Regex pinCode4 = new Regex("^[1-9]{4}$");
            if (pinCode4.IsMatch(pin) && !pin.Contains((char)10))
                isValidate = true;
            else if (pinCode6.IsMatch(pin) && !pin.Contains((char)10))
                isValidate = true;

            return isValidate;
        }

        static void Main(string[] args)
        {
            Console.Write(ValidatePin("1234\n"));
            Console.ReadKey();
        }
    }
}
