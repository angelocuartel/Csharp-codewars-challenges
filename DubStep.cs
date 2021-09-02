using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class DubStep
    {
        static string ReverseNum(int[] input)
        {
            /* dubstep
                StringBuilder newInput = new StringBuilder();
                bool isSpace = false;
                input = input.Replace("WUB", " ").Trim();

                foreach (char letter in input)
                {
                    if (letter == ' ' && isSpace == false)
                    {
                        newInput.Append(' ');
                        isSpace = true;
                    }
                    else if(letter != ' ')
                    {
                        newInput.Append(letter);
                        isSpace = false;
                    }
                }

                return newInput.ToString();
                */

            return (input.Sum()) % 2 == 0 ? "even" : "odd";


        }
    }
}
