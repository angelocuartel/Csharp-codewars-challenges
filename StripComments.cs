using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StripComments
    {
        public static string Strip(string numbers)
        {
            int countSpace = 1;
           foreach(char num in numbers)
            {
                if(num.ToString() ==" ")
                {
                    countSpace++;
                }
            }

            int[] numbersArr = new int[countSpace];
            numbers += " ";
            for(int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(numbers.Substring(0, numbers.IndexOf(" ")));
                numbers = numbers.Remove(0,numbers.IndexOf(" ")+1);
            }

            Array.Sort(numbersArr);

            return numbersArr[numbersArr.Length-1].ToString()+" "+numbersArr[0];
            
            
        }

        public static string reverse(string s)
        {
            string text = "";
           foreach(char letter in s)
            {
                if (char.IsLetter(letter))
                    text += letter;
            }
            char[] rev = text.ToCharArray();
            Array.Reverse(rev);
           return new string(rev);
            

        }

        public static int[] LowHigh(int[] input)
        {
            int[] highSecond = { 0, 0 };

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > highSecond[j])
                    {
                        highSecond[j] = input[i];
                    }
                }
            }
        }


        static void Main(string [] args)
        {
            int[]input = { 1, 4, 12, 54, 2, 41 };
            Console.Write(LowHigh(input));
            Console.ReadKey();
        }
    }
}
