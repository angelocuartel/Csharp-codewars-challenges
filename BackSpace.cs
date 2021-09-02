using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class BackSpace
    {
        public static string CleanString(string s)
        {
            int count = 0;
           foreach(char l in s)
            {
                if (l.ToString() == "#")
                    count++;
            }

            for (int i = 0; i < count; i++)
            {
                if (s.IndexOf("#") != 0)
                    s = s.Remove(s.IndexOf("#") - 1, 2);
                else
                    s = s.Remove(s.IndexOf("#"), 1);
            }

            return s;
        }

        static void Main(string[] args)
        {
            Console.Write(CleanString("abc####d##c#"));
            Console.ReadKey();
        }
    }
}
