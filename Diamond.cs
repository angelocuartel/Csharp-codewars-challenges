using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Diamond
    {



        static void Main(string[] args)
        {
            int asteris = 1;
            for (int i = 1; i <= 3; i++)
            {

                for (int j = i; j <= 3; j++)Console.Write(" ");

                for (int j = 1; j <= asteris; j++)Console.Write("*");

               

                if (asteris == 5)
                {
                    asteris -= 2;
                    Console.WriteLine();
                    for(int k = 1; k <= 2;k++)
                    {
                        for(int j = 0;j <= k; j++) Console.Write(' ');

                        for(int j = 1; j <= asteris; j++)Console.Write('*');

                        asteris -= 2;
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                asteris += 2;

            }



            Console.ReadKey();
        }
    }
}
