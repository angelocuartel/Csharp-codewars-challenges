using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{/*Write a program that converts a decimal number to hexadecimal one.*/
    class Ex_Numeral6
    {
        private static string ReverseArr(params int []arr)
        {
            string temp = "";
            for(int i = arr.Length-1; i != -1; i--)
            {
                if(arr[i] == 10)
                {
                    temp += "A";
                }
                else if(arr[i] == 11)
                {
                    temp += "B";
                }
                else if(arr[i] == 12)
                {
                    temp += "C";
                }
                else if(arr[i] == 13)
                {
                    temp += "D";
                }
                else if(arr[i] == 14)
                {
                    temp += "E";
                }
                else if(arr[i] == 15)
                {
                    temp += "F";
                }
                else
                {
                    temp += arr[i];
                }
            }
      
            return temp;
        }

        private static string DecimalToHexd(int dec)
        {
            int[] hexHolder = new int[16];
            int i = 0;
           while(dec >1)
            {
                hexHolder[i] += dec % 16;
                dec = dec / 16;
                i++;
            }
            return ReverseArr(hexHolder);
          

        }

        static void Main(string[] args)
        {
            Console.Write("Enter a Decimal Number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("HexaDecimal: {0}",DecimalToHexd(input));

                
           
            
            Console.ReadKey();
        }
    }
}
