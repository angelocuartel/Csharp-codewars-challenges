using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class NewChallenge
    {
      static bool Palindrome(object line)
        {
            /*bool palindrome = true;
            for(int i = 0; i < ((input.Length)/2); i++)
            {
                palindrome = (input.Substring(i,1) == input.Substring((input.Length-1)-i,1)) ? true : false  ;
                if (palindrome == false)
                    break;
            }
            return palindrome;
            */

            string reverse = "";
            for (int i = line.ToString().Length - 1; i > -1; i--)
            {
                reverse += line.ToString().Substring(i, 1);
            }
            return reverse == line.ToString() ? true : false;
        }

        static void Main(string [] args)
        {
            Console.Write(Palindrome("abba"));
            Console.ReadLine();
        }
      
    }
}
