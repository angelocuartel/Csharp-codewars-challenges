using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ReplaceString
    {
        public static string ReplaceAll(string input, string find, string replace)
        {
            StringBuilder texts = new StringBuilder();
            if (find == string.Empty)
            {
                foreach (char letter in input)
                {
                    texts.Append($"{replace}{letter}");
                }
                texts.Append(replace);
            }
            else
            {
                input = input.Replace(find, replace);
                texts.Append(input);
            }
            return texts.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write(ReplaceAll("123", "", "-"));
            Console.ReadKey();
        }
    }
}
