using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class MovingZeros
    {
        public static string MoveZeroes(int[] arr)
        {
            int[] numbers = new int[arr.Length];
            int countZero = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                { 
                    numbers[numbers.Length - 1 - i] = 0;
                    countZero++;
                 }
                
            }
            int count = numbers.Length-1;
            for(int i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    numbers[count - countZero] = arr[i];
                    count--;
                }
            }

            string num = "";
            for(int i = 0; i < numbers.Length; i++)
            {
                num += numbers[i];
            }
            return num;
  }


        static void Main(string[] args)
        {
            int[] numbesr = { 1,2,0,1,0,1,0,3,0,1 };
            Console.Write(MoveZeroes(numbesr));
            Console.ReadKey();
        }
    }
}
