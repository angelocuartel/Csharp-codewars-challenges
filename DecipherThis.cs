using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class DecipherThis
    {

        public static string Decode(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                string answer, alpha, charN, decode;
                answer = alpha = charN = decode = string.Empty;
                string[] letters = word.Split(' ');

                foreach (var letter in letters)
                {
                    foreach (char charL in letter)
                    {
                        if (char.IsNumber(charL)) charN += charL;
                        else alpha += charL;
                    }

                    decode += (char)int.Parse(charN);
                    charN = string.Empty;
                    if (alpha != string.Empty)
                    {
                        alpha = ((alpha.Insert(alpha.Length - 1, alpha.Substring(0, 1))).Remove(0, 1)).Insert(0, alpha.Substring(alpha.Length - 1, 1)).Remove(alpha.Length, 1).Insert(0, decode);
                        answer += $"{alpha} ";
                    }
                    else answer += $"{decode} ";
                       decode = string.Empty;
                        alpha = string.Empty;
                }

                return answer.Trim();
            }
            else return word;

        }


        static void Main(string[] args)
        {
            Console.Write(Decode("72olle 103doo 100ya"));
            Console.ReadKey();
        }
    }
}
