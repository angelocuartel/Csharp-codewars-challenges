using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Numeral3
    {
       private static double HexToDec(string input)
        {
            double dec = 0;

             for(int i =0; i < input.Length; i++)
            {

                dec += Convert.ToInt32(HexConVertLetters(input.Substring((input.Length-1)-i,1)))* Math.Pow(16,i);
            }
            Console.WriteLine("Decimal: "+dec);
            return dec;
            
        }
   

       private static string HexConVertLetters(string letter)
        {
            string returnLetter = "";
            switch (letter)
            {
                case "A":
                    returnLetter = "10";
                    break;
                case "B":
                    returnLetter = "11";
                    break;
                case "C":
                    returnLetter = "12";
                    break;
                case "D":
                    returnLetter = "13";
                    break;
                case "E":
                    returnLetter = "14";
                    break;
                case "F":
                    returnLetter = "15";
                    break;
                default:
                    returnLetter = letter.ToString();
                    break;
            }
            
            return returnLetter;
        }


        private static void DecimalBinary(int dec)
        {
        
            string decBi = "";
            string binary = "";

            while(dec > 0)
            {
                decBi += dec % 2;
                dec = dec / 2;
                
            }
            for (int i = 0; i < decBi.Length; i++)
            {
                binary += decBi.Substring((decBi.Length - 1) - i, 1);
            }
            Console.Write("binary: "+binary);
        }

     static  void Main(string[] args)
        {
            Console.Write("Enter a HexaDecimal value: ");
            string input = Console.ReadLine();
  
            DecimalBinary(Convert.ToInt32(HexToDec(input)));
            Console.ReadKey();
        }
    }
}
