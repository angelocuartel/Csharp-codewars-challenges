using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Pangram
    {

        public static bool IsPanagram(string s)
        {
            return "abcdefghijklmnopqrstuvwxyz".ToCharArray().All(c => s.Contains(c));
        }

        static void Main(string[] args)
        {
            Console.Write(IsPanagram("The quick brown fox jumps over the lazy dog"));
            Console.ReadKey();
        }
    }
}
