using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class BowlingPins
    {
        static string GetDownPins(params int[]arr)
        {
            var bowls = "7 8 9 0\n 4 5 6 \n  2 3  \n   1   ";
            StringBuilder newBowls = new StringBuilder();
            int index = 0;

            foreach(int number in arr)
            {
                foreach(char letter in bowls)
                {
                    if (letter != (char)10 && letter !=' ' && number == int.Parse(letter.ToString()))
                    {
                            bowls = bowls.Remove(index, 1).Insert(index, " ");
                        break;
                    }
                    else if(number == 10)
                    {
                        bowls = bowls.Remove(6, 1).Insert(6, " ");
                        break;
                    }
                    index++;
                }
                index = 0;
            }

            foreach(char letter in bowls)
            {
                if(letter != ' ' && letter != (char)10)
                {
                    newBowls.Append("I");
                    continue;
                }
                newBowls.Append(letter);

            }


            return newBowls.ToString();
        }

        static void Main(string[] args)
        {

            Console.Write(GetDownPins(1,2,3));
            Console.ReadKey();
        }
    }
}
