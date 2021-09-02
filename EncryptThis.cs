using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace TrainingGround
{
    class EncryptThis
    {
        public static string Encrypt(string input)
        {

            var answer = new StringBuilder();
            string[] words = input.Split(' ');

            foreach (var item in words)
            {
                if (item.Length > 1)
                    answer.Append($"{Convert.ToInt32(item[0])}{item.Remove(0, 1).Insert(item.Length - 1, item[1].ToString()).Insert(1, item[item.Length - 1].ToString()).Remove(0, 1).Remove(item.Length - 2, 1)} ");
                else if (string.IsNullOrEmpty(item)) answer.Append("");
                else answer.Append($"{Convert.ToInt32(item[0])} ");
            }


            return answer.ToString().Trim();
            
        }

        static void Main(string[] args)
        {
            Console.Write(Encrypt("A"));
            Console.ReadKey();
        }
    }
}
