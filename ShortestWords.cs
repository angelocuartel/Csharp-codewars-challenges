using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ShortestWords
    {
        public static int FindShort(string s)
        {
            string[] words = s.Split(' ');
            int[] lengths = new int[words.Length];
            for (int i = 0; i < lengths.Length; i++) lengths[i] = words[i].Length;
            Array.Sort(lengths);
            return lengths[0];
        }

        static void Main(string[] args)
        {
            Console.Write(FindShort("the great war oh"));
            Console.ReadKey();
        }
    }
}
