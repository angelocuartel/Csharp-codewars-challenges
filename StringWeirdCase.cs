using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StringWeirdCase
    {
        static void Main(string[] args)
        {
            string word = "This is a test";
            int count = 0;
            StringBuilder words = new StringBuilder();
         for(int index = 0; index < word.Length; index++)
            {
              
                 if (word[index] == ' ')
                {
                    words.Append(' ');
                    count = 0;
                }
               else if (count == 0 || count % 2 == 0)
                {
                    words.Append(word.Substring(index, 1).ToUpper());
                    count++;
                }
                else
                {
                    words.Append(word.Substring(index, 1).ToLower());
                    count++;
                }
            }

            Console.Write(words);
            Console.ReadKey();
        }
    }
}
