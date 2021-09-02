using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class CodeWars
    {
        public static string AlphabetPosition(string text)
        {
            text = text.ToLower();
            text = text.Replace(" ", "");
            string letterPosition = "";
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int t = 0; t <text.Length; t++)
            {
                for (int index = 0; index < letters.Length; index++)
                {
                    if (text.Substring(t, 1).Equals(letters[index].ToString(),StringComparison.CurrentCultureIgnoreCase))
                    {
                        letterPosition += (index + 1) + " ";
                    }
                }
            }
            return letterPosition.TrimEnd();
        }

        static void Main(string []args)
        {
            Console.Write(AlphabetPosition("The sunset sets at twelve o' clock"));
            Console.ReadKey();
        }
        
    }
}
