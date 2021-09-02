using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class AlphabetWar
    {

        public static string GetAlphabetWar(string fight)
        {
            char[] lefts = { 's', 'b', 'p', 'w' };
            char[] rights = {'z','d','q', 'm' };

            var right = 0;
            var left = 0;

            foreach(var c in fight)
            {
                if (lefts.Contains(c)) left += Array.IndexOf(lefts, c)+1;
                else right += Array.IndexOf(rights, c)+1;
            }

            if (right > left) return "Right side wins!";
            else if (left > right) return "Left side wins!";
            else return "Let's fight again!";


        }


        static void Main(string[] args)
        {
            Console.WriteLine(GetAlphabetWar("zdqmwpbs"));
            Console.ReadKey();
        }
    }
}
