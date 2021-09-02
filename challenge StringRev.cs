using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class challenge_StringRev
    {
    public static void Main(string [] args)
        {

            Console.Write("Enter a String   ");
            string input = Console.ReadLine();
            int counter = 0;
            string reverseString = "";
            while(counter < input.Length)
            {

                if((input.Substring(counter,1).ToUpper()) == (input.Substring(counter, 1)))
                {

                    reverseString +=(input.Substring(counter,1).ToLower());
                }
                else
                {
                    reverseString += (input.Substring(counter, 1).ToUpper());
                }


                counter++;
            }
            Console.WriteLine("Reverse input: {0}",reverseString);
            
            Console.ReadKey();
        }
    }
}
