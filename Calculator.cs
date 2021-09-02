using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Calculator
    {
        static List<string> exps = new List<string>();

        public static string CalculateExpression(string exp)
        {
            exps = exp.Split(' ').ToList();
            
            while (exps.Count != 1)
            {
                
                CalculateExp();

            }

            return exps[0];

        }

        public static void SetAnswer(double answer, int index)
        {

            exps.RemoveRange(index-1, 3);
            exps.Insert(index-1, answer.ToString());

        }

       

        public static void CalculateExp()
        {
            var ops = "(*/-+";
            foreach(var item in ops)
            {
                for (int i = 1; i < exps.Count - 1; i += 2)
                {

                    if (exps[i] == item.ToString() && item == '*')
                    {
                        SetAnswer(Convert.ToInt32(exps[i - 1]) * Convert.ToInt32(exps[i + 1]), i);
                        i -= 2;
                    }
                    else if (exps[i] == item.ToString() && item == '/')
                    {
                        SetAnswer(Convert.ToInt32(exps[i - 1]) / Convert.ToInt32(exps[i + 1]), i);
                        i -= 2;
                    }
                    else if (exps[i] == item.ToString() && item == '+')
                    {
                        SetAnswer(Convert.ToInt32(exps[i - 1]) + Convert.ToInt32(exps[i + 1]), i);
                        i -= 2;

                    }
                    else if (exps[i] == item.ToString() && item == '-')
                    {
                        SetAnswer(Convert.ToInt32(exps[i - 1]) - Convert.ToInt32(exps[i + 1]), i);
                        i -= 2;
                    }



                }
            }
            
        }




        

        


        static void Main(string[] args)
        {
     
            Console.WriteLine(CalculateExpression("34 + 21 * 12 + 54 * 3"));
            Console.ReadKey();
        }
    }
}
