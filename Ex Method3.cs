using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{

    /*Write a method that returns the English name of the last digit of a
given number. Example: for 512 prints "two"; for 1024  "four".
*/
    class Ex_Method4
    {
        static string input = "1";
        static void ConsoleInput()
        { 

            Console.Write("Enter a number: ");
             input = Console.ReadLine();
        }

        static string GetLastDigit(string digits)
        {
            string lastDigit = digits;
            return lastDigit = digits.Substring(digits.Length-1);
        }

        static string PrintLastDigit(string digit)
        {
                
            string lastdigit = "";
            switch (digit)
            {
                case "1":
                    lastdigit= "one";
                    break;

                case "2":
                    lastdigit = "two";
                    break;
             
                case "3":

                    return lastdigit = "three";
                   
                case "4":
                    lastdigit = "four";
                    break;

                case "5":
                    lastdigit = "five";
                    break;
                  
                case "6":
                    lastdigit = "six";
                    break;

                case "7":
                    lastdigit = "seven";
                    break;

                case "8":
                    lastdigit = "eight";
                    break;

                case "9":
                    lastdigit = "nine";
                    break;

                case "0":
                    lastdigit = "zero";
                    break;

                default:
                    lastdigit = "Probably not a Digit!";
                    break;

            }
            return lastdigit;
        }


        static void Main(string [] args)
        {
            ConsoleInput();
           Console.Write( PrintLastDigit(GetLastDigit(input)));
            Console.ReadKey();
        }
    }
}
