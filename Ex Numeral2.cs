using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Numeral2
    {
        private static double BinaryToDec(string input) { 
            double decStorage = 0;
            for (int i = 0; i < input.Length; i++)
            {
                decStorage += (Convert.ToInt32(input.Substring((input.Length-1)-i, 1))) *(Math.Pow(2,i));
            }
            return decStorage;
        }

        private static string DecToHex(double input)
        {
            string hexHolder = "";
           
            while (input > 1)
            {
                string tempHolder = "";
                tempHolder += (int)input % 16;
                input = input / 16;

                if(tempHolder == "10")
                {
                    hexHolder += "A";
                }
                else if(tempHolder == "11")
                {
                    hexHolder += "B";
                }
                else if (tempHolder == "12")
                {
                    hexHolder += "c";
                }
                else if (tempHolder == "13")
                {
                    hexHolder += "D";
                }
                else if (tempHolder == "14")
                {
                    hexHolder += "E";
                }
                else if (tempHolder == "15")
                {
                    hexHolder += "F";
                }
                else
                {
                    hexHolder += tempHolder;
                }
            }



           return RevString(hexHolder);
        }

        private static string RevString(string input)
        {
            string revString = "";
          for(int i = input.Length-1;i != -1; i--)
            {
                revString += input.Substring(i,1);
            }

            return revString;          
        }

        static void Main(string [] args)
        {   
            Console.WriteLine("Enter a binary: ");
            string input = Console.ReadLine();

            Console.WriteLine(BinaryToDec(input));
            Console.WriteLine(DecToHex(BinaryToDec(input)));
            Console.ReadKey();

        }
    }
}
    

