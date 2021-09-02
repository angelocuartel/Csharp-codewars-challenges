using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Scrabble
    {
        public static int CalculateScrabbleWord(string word)
        {
            Dictionary<char, int> words = new Dictionary<char, int>()
            {
                {'a',1 },
                {'b',3 },
                {'c',3 },
                {'d',2 },
                {'e',1 },
                {'f',4 },
                {'g',2 },
                {'h',4 },
                {'i',1 },
                {'j',8 },
                {'k',5 },
                {'l',1 },
                {'m',3 },
                {'n',1 },
                {'o',1 },
                {'p',3 },
                {'q',10 },
                {'r',1 },
                {'s',1 },
                {'t',1 },
                {'u',1 },
                {'v',4 },
                {'w',4 },
                {'x',8 },
                {'y',4 },
                {'z',10 }

            };
            int bonus = 0, score = 0, carret = 0;
            var bonusWords = string.Empty;
            char doubleLet = ' ';

            foreach(char letter in word)
            {
                bonusWords = word.Contains("(t)") || word.Contains("(d)") ? word.Substring(word.Length - 3, 3) : string.Empty;
                if (letter == '*')
                {
                    score += words[doubleLet];
                   carret += words[doubleLet];
                }
                else if (letter == '^') score -= carret;
                else if (letter == '(') break;
                else
                {
                    carret = words[letter];
                    bonus++;
                    doubleLet = letter;
                    score += words[letter];
                }
            }
            if (bonusWords == "(d)") score = score * 2;
            else if (bonusWords == "(t)") score = score * 3;
            score += bonus >= 7 ? 50 : 0;

            return score;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CalculateScrabbleWord("burg^ers(t)"));
            Console.ReadKey();
        }
    }
}
