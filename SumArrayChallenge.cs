using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SumArrayChallenge
    {
        public static int Repeats(List<int> source)
        {
            int sum = 0;
            int hold = 0;
            for (int i = 0; i < source.Count; i++)
            {
                hold = source[i];
                source.Remove(source[i]);
                if (!source.Contains(hold))
                {
                    sum += hold;
                    source.Insert(i,hold);
                }
                else
                    source.Insert(i,hold);    
            }
            return sum;
        }
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(4);
            num.Add(5);
            num.Add(7);
            num.Add(5);
            num.Add(4);
            num.Add(8);
            Console.Write(Repeats(num));
            Console.ReadKey();
        }
    }
}
