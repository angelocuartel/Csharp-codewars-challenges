using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class MessageValidation
    {

        public static bool IsMessageValid(string message)
        {

            var nums = new StringBuilder();
            var words = new StringBuilder();
            if (message == string.Empty) return true;
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    if (i == message.Length - 1 && char.IsDigit(message[i])) return false;
                    else if (char.IsDigit(message[i]) && char.IsDigit(message[i + 1]))
                        nums.Append(message[i]);
                    else if (char.IsDigit(message[i]) && !char.IsDigit(message[i + 1]))
                    {
                        nums.Append($"{message[i]},");
                        words.Append(',');
                    }
                    else if (char.IsLetter(message[i]))
                        words.Append(message[i]);
                }

                var values = nums.ToString().Trim(',').Split(',');
                var strings = words.ToString().Trim(',').Split(',');

                if (values.Length != strings.Length) return false;
                else
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (int.Parse(values[i]) != strings[i].Length) return false;

                    }
                }

                return true;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsMessageValid("3hey5hello2hi5"));
            Console.ReadKey();
        }
    }
}
