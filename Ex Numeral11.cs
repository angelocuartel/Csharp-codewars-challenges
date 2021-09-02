using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingGround
{
    class Ex_Numeral11
    {

 
        static string roman;
        static int input;
       static char enterValue;
        static void CheckFour(int minus,char romanFour)
        {
           
            int number = int.Parse(input.ToString().Substring(0,1));
            if (number == 4)
            {
                roman += romanFour;
                input = input.ToString().Length > 1? int.Parse(input.ToString().Remove(0,1)):0;

            }
            else if (number != 4 && number != 9)
                input -= minus;
        }

        static void CheckNine(int minus,char recentRoman,char romanNine)
        {

            int number = int.Parse(input.ToString().Substring(0,1));
            if (number == 9)
            {
            roman = roman.Remove(roman.Length - 1, 1);
                roman += recentRoman;
                roman += romanNine;
                input = input.ToString().Length > 1 ? int.Parse(input.ToString().Remove(0, 1)) : 0;
            }
            else if (number != 4 && number != 9)
            {
                input -= minus;
            }
        }

    
        
       static void Main (string [] args)
        {
            do
            {
                Console.Write("Enter a Number: ");
                input = int.Parse(Console.ReadLine());
                while (input != 0)
                {
                    if (input >= 1 && input < 5 )
                    {
                        roman += 'I';
                        CheckFour(1, 'V');
                    }
                    else if (input >= 5 && input < 10 )
                    {
                        roman += 'V';
                        CheckNine(5,'I','X');
                       
                    }
                    else if (input >= 10 && input < 50)
                    {
                        roman += 'X';
                        CheckFour(10, 'L');

                    }
                    else if (input >= 50 && input < 100)
                    {
                        roman += 'L';
                        CheckFour(50, 'C');
                        CheckNine(50,'X','C');
                    }
                    else if (input >= 100 && input < 500)
                    {
                        roman += 'C';
                        CheckFour(100, 'D');
                    }
                    else if (input >= 500 && input < 1000)
                    {
                        roman += 'D';
                        CheckFour(500, 'M');
                        CheckNine(500,'C','M');
                    }
                    else
                    {
                        roman += 'M';
                        CheckFour(1000, 'C');
                    }
                }
                Console.WriteLine("Roman Value: " + roman);
                roman = "";
                Console.Write("Enter another value (y/n): ");
                enterValue = Convert.ToChar(Console.ReadLine());
            }
            while (enterValue == 'y' && enterValue != 'n');
           
        }
    }
}
