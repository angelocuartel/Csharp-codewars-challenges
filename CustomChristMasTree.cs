using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class CustomChristMasTree
    {

       
        public static string GetTree(string chars, int n)
        {
            var indexChar = 0;
            StringBuilder answer = new StringBuilder();
            for(int row = 1; row <= n; row++)
            {
                for(int space = 1; space <= n - row; space++)
                {
                    answer.Append(' ');
                }

                for (int content = 1; content < row+1 ; content++)
                {
                    

                    if(indexChar > chars.Length-1)indexChar = 0;

                    answer.Append($"{chars[indexChar]} ");

                    indexChar++;
                }

                    
                    answer.Remove(answer.Length - 1, 1).AppendLine();
                  
            }

            var times = n;

            while(n > 2)
            {
                answer.Append(' ',times-1);
                answer.AppendLine("|");
                n -= 3;
            }

            Console.WriteLine(answer);
            return answer.ToString().Remove(answer.Length-1,1);

        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetTree("*@o", 3));
            Console.ReadKey();
        }
    }
}
