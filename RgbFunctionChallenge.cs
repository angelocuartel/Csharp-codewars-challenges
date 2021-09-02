using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class RgbFunctionChallenge
    {
        public static string Rgb(int r, int g, int b)
        {
            int[] rgb = { r, g, b };
            string letters = "";

            for (int i = 0; i < rgb.Length; i++)
            {
                if (rgb[i] > 255)
                    letters += "FF";

                else if (rgb[i] < 0)
                    letters += "00";


                else if (rgb[i] < 17)
                {
                    letters +="0"+ Convert.ToString(rgb[i],16);
                }
                else
                {
                    letters += Convert.ToString(rgb[i],16);
                }
            }

            

            return letters.ToUpper();
            
        }

        static void Main(string[] args)
        {
           
            Console.Write(Rgb(212, 53, 12));
            Console.ReadKey();
        }
    }
}
