using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class _2dArray
    {

        static void Main(string[] args)
        {
            string [,]exp =
              {
                {"nyrico","87"},
                {"angelo","90"},
                {"angela","91"},
                {"luis","75"}
            };


            var texts = new StringBuilder();

            for(int i = 0; i < exp.GetLength(0); i++)
            {
                bool isOdd = true;

                for (int j = 1; j <= Math.Pow((double)exp.GetLength(1),2); j+=2)
                {
                    if (isOdd)
                    {
                        texts.Append($"{exp[i, j]},");
                        isOdd = false;
                    }
                    else
                    {
                        texts.Append($"{exp[i, j - 3]},");
                        isOdd = true;
                    }
                }

                texts.Remove(texts.Length - 1, 1);
                texts.Append(' ');
            }

            var newList = (texts.ToString().Remove(texts.Length-1,1).Split(' ')).OrderByDescending(v => v).ToArray();

            foreach (var item in newList) Console.WriteLine(item);
            Console.ReadKey();

        }
    }
}
