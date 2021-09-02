using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingGround
{/*Write a program that converts a binary number to decimal 
    */
    class binary
    {

        private static double BinaryToDec(string binary)
        {
            double binaryDec = 0;
            for(int i = 0; i < binary.Length; i++)
            {
                binaryDec+= Convert.ToInt32(binary.Substring((binary.Length-1)-i,1)) * (Math.Pow(2,i));
            }

            return binaryDec;
        }
        static void Main(string [] args)
        {
            Console.Write("Enter a Binary Digits: ");
            string input = Console.ReadLine();
           
            Console.Write("Decimal Value:{0}",BinaryToDec(input));
            Console.ReadLine();

        }
    }
}
