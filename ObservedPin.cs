using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ObservedPin
    {
        public static string GetPin()
        {
            bool correct = false;
            Random num1 = new Random();
            int[] digit1 = { 1, 2, 4 };
            int[] digit2 = { 2, 3, 6 };
            int[] digit3 = { 2, 4, 5, 6, 8 };
            int[] digit4 = { 4, 7, 8 };
            string pin = "2624";
            string pass = "";
            while (!correct)
            {
                pass += digit1[num1.Next(0, 2)] +""+digit2[num1.Next(0, 2)] + "" + digit3[num1.Next(0, 4)] + "" + digit4[num1.Next(0, 2)];
                if(pass == pin)
                {
                    correct = true;
                
                }
                else
                {
                    pass = "";
                    
                }
            }
            return correct.ToString()+pass ;
        }

        static void Main(string[] args)
        {
            Console.Write(GetPin());
            Console.ReadKey();
        }
    }
}
