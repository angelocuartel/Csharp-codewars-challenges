using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Scrambles
    {
        public static bool Scramble(string str1, string str2)
        {

            for(int i =0; i < str2.Length; i++)
            {
                if (!str1.Contains(str2[i]))
                {
                    return false;
                }
                else
                {
                    str1 = str1.Remove(str1.IndexOf(str2[i]), 1);
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Scramble("rkqodlw","worldz"));
            Console.ReadKey();
        }
    }
}
