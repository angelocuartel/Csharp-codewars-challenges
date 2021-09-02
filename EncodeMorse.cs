using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class EncodeMorse
    {
        public static string Encode(string words)
        {
            words = words.ToLower();
            StringBuilder morse = new StringBuilder();
            Dictionary<char, string> morseCode = new Dictionary<char, string>()
            {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},

            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {' ', "   "},
            {'.', ".-.-.-"},
            {',', "--..--"},
            {':', "---..."},
            {'?', "..--.."},
            {'!', "..--."},
            {'\'', ".----."},
            {'-', "-....-"},
            {'/', "-..-."},
            {'"', ".-..-."},
            {'@', ".--.-."},
            {'=', "-...-"}
            };
            words = words.Length - 1 == ' ' ? words.Remove(words.Length - 1, 1) : words;
            foreach (char letter in words)
                morse.Append(morseCode[letter] + " ");
            return morse.ToString().Substring(0, morse.Length - 2);
        }

        static void Main(string[] args)
        {
            Console.Write(Encode("xyfanopvA"));
            Console.ReadKey();
        }
    }
}
