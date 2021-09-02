using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ExObject5
    {

        static double Hypotenus(int num1,int num2)
        {
            return (Math.Sqrt(num1)+Math.Sqrt(num2));
        }
        static void Main(string [] args)
        {
            Console.WriteLine("Enter a firstNumber: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a secondNumber: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.Write(Hypotenus(input1,input2));
            Console.ReadKey();
        }
    }
}
