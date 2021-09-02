using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StringCount
    {

        public static Dictionary<char, int> Count(string str)
        {

            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            var builder = new StringBuilder();
            int charCount = 0;



            for(int i = 0;i  < str.Length; i++)
            {
                if (!charDictionary.ContainsKey(str[i]))
                {

                    for(int j = i; j < str.Length; j++)
                    {
                        if(str[j] == str[i])
                        {
                            charCount++;
                        }
                    }

                    charDictionary.Add(str[i], charCount);
                    charCount = 0;
                }
            }
            
            return charDictionary;
        }
        public static void Main(string[] args)
        {
            foreach (var item in Count("aabb"))
            {
                Console.WriteLine(item.Key+ " "+item.Value);
            }

            Console.ReadKey();
        }
    }
}
