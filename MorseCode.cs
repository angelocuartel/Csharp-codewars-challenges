using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class MorseCode
    {
        public static string DecodeBits(string binary)
        {
            StringBuilder morseCode = new StringBuilder();
            Dictionary<string, string> bits = new Dictionary<string, string>()
            {
            { "11","."},
            {"00"," "},
            
            };
            
            binary = binary.Replace("0", " ").Trim().Replace(" ", "0");

            int minus = 0;
            int length = 0;
            int add = 0;
            if (binary.Contains("001100"))
            {
               length= minus = 2;
                add = 4;
            }
            else if (binary.Contains("000111000"))
            {
                length = minus = 3;
                add = 6;
            }
            for(int i = 0; i < binary.Length; i += add)
            {
                if (i != binary.Length - minus)
                {
                    if (binary.Substring(i+2, length) =="11")
                    {
                        morseCode.Append("-");
                        i += 4;

                    }
                    else
                    {
                        morseCode.Append(bits[binary.Substring(i, length)]);
                    }


                }
                else if (i == binary.Length- minus)
                {
                    morseCode.Append(bits[binary.Substring(i, length)]);
                    
                }
            }

            string hello = DecodeMorse(morseCode.ToString());

            hello += " ";
            StringBuilder decode = new StringBuilder();

            Dictionary<string, string> codesList = new Dictionary<string, string>()
            {
    {".-","A"},
    {"-...","B"},
    {"-.-.","C"},
    {"-.." , "D"},
    {".", "E"},
    {"..-." ,"F"},
    {"--." , "G"},
    {"...." , "H"},
    {".." , "I"},
    { ".---" , "J"},
    {"-.-" , "K"},
    {".-.." , "L"},
    {"--" , "M"},
    {"-." , "N"},
    {"---" , "O"},
    {".--." , "P"},
    {"--.-" ,"Q"},
    {".-." , "R"},
    {"..." , "S"},
    { "-" , "T"},
    {"..-" , "U"},
    {"...-" , "V"},
    {".--" , "W"},
    {"-..-" , "X"},
    {"-.--" , "Y"},
    {"--.." , "Z"},
    { "-----" , "0"},
    { ".----" , "1"},
    { "..---" , "2"},
    { "...--" , "3"},
    { "....-" , "4"},
    { ".....", "5"},
    { "-...." , "6"},
    { "--..." , "7"},
    { "---.." , "8"},
    { "----." ,"9"},
    { ".-.-.-" ,"."},
    { "-.-.--" ,"!"},
    { "...---...","SOS"}
          };

            for (int i = 50; i > 0; i--)
            {
                if (hello == string.Empty)
                    break;
                else if (hello[0] != ' ')
                {
                    decode.Append(codesList[hello.Substring(0, hello.IndexOf(" "))]);
                    hello = hello.Remove(0, hello.IndexOf(" ") + 1);
                }
                else
                {
                    decode.Append(' ');
                    hello = hello.TrimStart();
                }

            }

            return decode.ToString().Trim();

        }

        public static string DecodeMorse(string morseCode)
        {

            return morseCode;
        }

        static void Main(string[] args)
        {
            Console.Write(DecodeBits("0011001100110011"));
            Console.ReadKey();
        }
    }
}
