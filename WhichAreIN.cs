using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class WhichAreIN
    {

        public static void inArray(string[] array1, string[] array2)
        {
            List<string> answers = new List<string>();
            foreach(var i in array1)
            {
                foreach(var j in array2)
                {
                    if (j.Contains(i))
                    {
                        answers.Add(i);
                        break;
                    }
                }
            }
            answers.Sort(); 
            foreach (var item in answers) Console.WriteLine(item);
        }


        static void Main(string[] args)
        {
            string[] a1 = new string[] { "cod", "code", "wars","ewar" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" ,"codewars"};
           inArray(a1,a2);
            Console.ReadKey();
        }
    }
}
