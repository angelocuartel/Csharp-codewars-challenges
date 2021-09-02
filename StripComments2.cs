using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StripComments2
    {
      static string RemoveComments(string text, params string[] commentSymbols)
        {
            int count = 0;
            foreach(string symbol in commentSymbols)
            {
                for (int i =0; i < text.Length;i++)
                {
                    count += text.Substring(i,1) == symbol ? 1 : 0;
                    if (text[i] == (char)10)
                    {
                        count = 0;
                    }
                    else if (count > 0)
                    {
                        text = text.Remove(i, 1);
                        i--;
                    }
                   
                }
                count = 0;
            }
           string[] newText = text.Split((char)10);
        StringBuilder newVerText = new StringBuilder();
         foreach (string words in newText) newVerText.AppendLine(words.TrimEnd());
            return newVerText.ToString();
        }

        static void Main(string[] args)
        {
            string[] symbols = { "#","!" };
            Console.Write(RemoveComments("apples, pears # and bananas\ngrapes\nbananas !apples", symbols));
            Console.ReadKey();
        }
    }
}
