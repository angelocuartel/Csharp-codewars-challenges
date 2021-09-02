using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace TrainingGround
{
    class PascalTriangle
    {
        public static void GetPascal(int n)
        {

            var num = "1 1 ";
            var answer = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                if (i >= 3)
                {
                    var tempNum = string.Empty;
                    var temp = num.Remove(num.Length - 1, 1).Split(' ');
                    for (int j = 0; j < temp.Length - 1; j++)
                    {
                        tempNum += $"{(int.Parse(temp[j]) + int.Parse(temp[j + 1])).ToString()} ";
                    }

                    num = string.Empty;
                  num = $"1 {tempNum}1 ";
                    answer += num;
                }

                else
                {
                    for (int j = 1; j <= i; j++)
                        answer += "1 ";
                }
            }
 

            var tempList = answer.Remove(answer.Length - 1, 1).Split(' ').ToList();
            var finalList = new List<int>();
            foreach (var item in tempList) finalList.Add(int.Parse(item));
            foreach (var item in finalList) Console.Write(item+" ");



        }



        static void Main(string[] args)
        {
            GetPascal(20);
            Console.ReadKey();
        }
    }
}
