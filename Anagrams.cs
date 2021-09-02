using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Anagrams
    {
        public static void GetAnaGrams(string[]strings,string s)
        {

            List<string> anagrams = new List<string>();

            string word;
            foreach(var item in strings)
            {
                word = item;
                foreach (char letter in s)
                {
                    if (word.Contains(letter) && s.Length == item.Length)
                    {
                        word = word.Remove(word.IndexOf(letter), 1);

                    }
                    else break;

                    if (string.IsNullOrEmpty(word))
                    {
                        anagrams.Add(item);
                    }
                }
            }

            foreach (var item in anagrams) Console.WriteLine(item);
           
        }

        static void Main(string[] args)
        {
            GetAnaGrams(new string[] { "aabb", "abcd", "bbaa", "dada" },"abba");
            Console.ReadKey();
        }
    }
}
