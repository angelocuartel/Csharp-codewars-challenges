using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{/*Write a method that finds how many times certain number can be
found in a given array. Write a program to test that the method works
correctly.
    */
    class Ex_Method4
    {

        static int CountNumber(int[]arrNum,int number)
        {
            int countNumber = 0;
           for(int i = 0; i < arrNum.Length; i++)
            {
                if(number == arrNum[i])
                {
                    countNumber ++;
                }
            }
            return countNumber;
        }

     static void Main(string[] args)
        {
            Console.Write("Enter an Array Length: ");
            int length = int.Parse(Console.ReadLine());

            int[] num = new int[length];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter Elements of an Array: ");
                int numTemp = int.Parse(Console.ReadLine());
                num[i] = numTemp;

            }

            Console.Write("Enter a number that you want to find if it has same element in the Array: ");
            int number = int.Parse(Console.ReadLine());


            Console.WriteLine("\"{0}\" number exist {1} times in the Array",number,CountNumber(num,number));
            Console.ReadKey();


        }
    }
}
