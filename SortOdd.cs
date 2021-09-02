using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SortOdd
    {
       
        

        static void Main(string[] args)
        {


            int[] numbers = { 5, 3, 2, 8, 1, 4 };

            for(int i = 0; i < numbers.Length; i++)
            {
                int minimum = i;
                for(int j = i+1; j < numbers.Length; j++)
                    if(numbers[minimum] > numbers[j] && numbers[j] % 2 != 0 && numbers[minimum] % 2 != 0)  minimum = j;

                if(minimum != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[minimum];
                    numbers[minimum] = temp;
                }
            }

            foreach(int num in numbers)
            {
                Console.Write($"{num} ");

            }
            Console.ReadKey();
 
        }
    }
    }

