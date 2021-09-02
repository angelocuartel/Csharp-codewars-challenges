using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class EnglishBeggars
    {

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] beggars = new int[3];
            int even = 3;
            int count = 0;

            for (int beggar = 0; beggar < beggars.Length; beggar++)
            {
         
                for(int index = count; index < numbers.Length; index+=even)
                {
                    beggars[beggar] += numbers[index];
                }
                count++;
            }
            Console.WriteLine(beggars[1]);
            Console.ReadKey();
        }
    }
}
