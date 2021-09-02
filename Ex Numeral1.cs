using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Ex_Numeral1
    {


        // user define method that converts decimal to binary
        private static void BinaryConverter(params int[] input)
        {
            string[] binaries = new string[input.Length];
            for(int row = 0; row < input.Length; row++)
            {
               while(input[row] != 0)
                {
                    binaries[row] += Convert.ToString((input[row] % 2));
                    input[row] = input[row] / 2;

                }

            
            }

            for(int i = 0; i < binaries.Length; i++)
            {
                BinaryReverse(binaries[i]);
            }

        }
        // user define methods that reversed a binary from most significant bit to least significant bit
        private static void BinaryReverse(params string[] input )
        {
            string stringHolder = "";
            for (int row = 0; row < input.Length; row++)
            {
               for(int i  = input[row].Length-1; i != -1; i--)
                {
                    stringHolder += input[row].Substring(i,1);
                }
            }

            Console.WriteLine(stringHolder);
        }


        static void Main(string [] args)
        {

            BinaryConverter(151,35,43,251,1023,1024);
            Console.ReadKey();
        }

    }
}
