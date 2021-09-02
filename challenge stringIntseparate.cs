using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class challenge1
    {
        static string input ;
      
    static void Input()
        {
            Console.Write("Enter letters or numbers: ");
             input = Console.ReadLine();
        }
        

    static void Proccess(string number,string letter)
        {
            input = input.Replace(" ", "");
           
             for(int i = 0; i < input .Length; i++)
             {

                 int a;
                 bool checker = int.TryParse(input.Substring(i, 1), out a);
                 if (checker)
                 {
                     number += input.Substring(i, 1);
                 }
                 else
                 {
                     letter += input.Substring(i, 1);
                 }
             }


             Console.Write("numbers: {0}\nletters: {1}",number,letter);
         
        }


        

        public static void Main (string[] args)
        {
            string numbers = "", letters = "";
            Input();
            Proccess(numbers, letters);
            Console.ReadKey();
        }
     
    }
}
