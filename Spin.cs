using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TrainingGround
{
    class Spin
    {
        public static string SpinWords(string sentence)
        {
            string stringHolder = "";
            string reverseString = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (stringHolder.Length >= 5)
                {
                    reverseString = "";
                    for (int j = stringHolder.Length - 1; j >= 0; j--)
                    {
                        reverseString += stringHolder.Substring(j, 1);
                    }
                    reverseString += " ";
                    stringHolder = "";
                }
                else
                {
                    reverseString += stringHolder += sentence[i];
                }
            }
            return reverseString;
        }
        static void Main (string [] args)
        {
            Console.Write(SpinWords("this is a test"));
            Console.ReadKey();
    
        }


     
       
    }

 
}
