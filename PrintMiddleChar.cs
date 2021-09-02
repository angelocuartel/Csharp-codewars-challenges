using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class PrintMiddleChar
    {
      public  static string input ="";
        public static void InputString()
        {
            Console.Write("Enter a String/phrase: ");
             input = Console.ReadLine();
            
          
        }


       public  static string MiddleCharFinder()
        {
            return (input.Length % 2) == 0 ? input.Substring((input.Length / 2)-1, 2): input.Substring((input.Length / 2) , 1);

        } 
    }


    class main : PrintMiddleChar
    {
        static void Main (string [] args)
        {
            InputString();
            Console.Write("middle Character of \"{0}\" is/are : \"{1}\"",input,MiddleCharFinder());
            Console.ReadKey();

        }
    }
}
