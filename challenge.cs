using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class challenge
    {
       private static string StringManupulation(string input)
        {
            string newLetters = "";
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < letters.Length; j++)
                {
                    if (input.Substring(i,1).Equals(Convert.ToString(letters[j]), StringComparison.InvariantCultureIgnoreCase))
                    {
                        newLetters += letters[j + 1];
                    }

                }

                if(input.Substring(i,1) ==" ")
                {
                    newLetters += " ";
                }
            }
            return newLetters;
        }

        static void Main(string [] args)
        {
            Console.Write("Enter a Word/Phrase: ");
            string input = Console.ReadLine();
            Console.WriteLine(StringManupulation(input));
            Console.ReadKey();
        }
    }
}
