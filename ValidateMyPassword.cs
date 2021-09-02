using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ValidateMyPassword
    {

        static string ValidatePass(string p)
        {
            return IsPasswordLength(p) && !HasSymbol(p)  && HasLetters(p) && HasNumbers(p) ? "VALID" : "INVALID";
        }


        static bool HasSymbol(string p)
        {
            var symbols = "!@#$%^&*()-+~`{}[]:;\"\\|?/><,.";
            var hasSymbol = false;

            foreach(var s in symbols)
            {
                if (p.Contains(s))
                {
                    hasSymbol = true;
                    break;
                }
            }

            return hasSymbol;

        }

        static bool HasLetters(string p)
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";

            var hasLet = false;

            foreach(var item in letters)
            {
                if (p.Contains(item))
                {
                    hasLet = true;
                    break;
                }
            }


            return hasLet;

        }


        static bool HasNumbers(string p)
        {
            var nums = "1234567890";

            var hasNums = false;

            foreach (var item in nums)
            {
                if (p.Contains(item))
                {
                    hasNums = true;
                    break;
                }
            }

            return hasNums;
        }


        static bool IsPasswordLength(string p)
        {
            return p.Length < 20 && p.Length > 3 ? true : false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePass("ThisPasswordIsTooLong1234!"));
            Console.ReadKey();
        }
    }
}
