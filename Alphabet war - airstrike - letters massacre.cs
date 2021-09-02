using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Alphabet_war___airstrike___letters_massacre
    {

        public static string GetWarResult(string fight)
        {
      
            var length = fight.Length;

            for (int i = 0; i < fight.Length-1; i++)
            {
                if (fight[i] == '*' && i > 0 && i != fight.Length - 1)
                {
                    fight = fight[i + 1] != '*' ? fight.Remove(i - 1, 3).Insert(i - 1, "|||") : fight.Remove(i - 1, 2).Insert(i - 1, "||");
                }
                else if (fight[i] == '*' && i < 1)
                {
                    fight = fight[i + 1] != '*' ? fight.Remove(0, 2).Insert(0, "||") : fight.Remove(0, 3).Insert(0, "|||");
                }
                else if (fight[i] == '*' && i == fight.Length - 1) fight = fight.Replace(fight.Substring(i - 1, 2), "||");
                Console.WriteLine($"{fight} {i}");
            }

            //fight = fight.Replace("|", string.Empty);
            

            var left = fight.Sum(f => "sbpw".IndexOf(f.ToString()) + 1);
            var right = fight.Sum(f => "zdqm".IndexOf(f.ToString()) + 1);

            return left > right ? "Left side wins!" : right > left ? "Right side wins!" : "Let's fight again!";

           
        }


        static void Main(string[] args)
        {
            Console.WriteLine(GetWarResult("bknho*t*d*cdbdb**b*mlbwcqr"));
            Console.ReadKey();
        }
    }
}
