using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StringTask
    {
       static string RemoveConsonant(string text)
        {
            text = text.ToLower();
            var vowels = new ArrayList()
            {
                'a',
                'e',
                'i',
                'o',
                'u',
                'y'
            };
            foreach (char vowel in vowels) text = text.Replace(vowel.ToString(),string.Empty);
            StringBuilder newText = new StringBuilder();
            foreach (char let in text) newText.Append($".{let}");
            return newText.ToString();
        }

        public static void Main(string[] args)
        {
            Console.Write(RemoveConsonant("codewars"));
            Console.ReadKey();
        }
    }
}
