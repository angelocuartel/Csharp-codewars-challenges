using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ChristmasTree
    {

        public static string PrintTree(int height)
        {

            StringBuilder answer = new StringBuilder();
            int minus = 1;

            for(int i = 0; i < height; i++)
            {
                for (int k = 1; k < height - i; k++) answer.Append(' ');

                for (int j = 0; j < i + minus; j++) answer.Append('*');

                answer.AppendLine();

                minus++;
            }

            return answer.ToString();
        }

        static void Main(string[] args)
        {
            PrintTree(5);
            Console.ReadKey();
        }
    }
}
