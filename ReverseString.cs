using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ReverseString
    {
        public static String solve(String s)
        {
            string copy = s;
            s = s.Replace(" ", "");
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            s = new string(rev);

            for (int i = 0; i < copy.Length; i++)
            {
                if (copy.Substring(i, 1) == " ")
                    s = s.Insert(i, " ");
            }

            return s;
        }

        static void Main(string[]args  )
        {
            Console.Write(solve("your code rocks"));
            Console.ReadKey();
        }
    }
}
