using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class MissingAlphabet
    {
        public static string MissingAlphabets(string s)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            int count =0,finalCount = 0;

            for(int i = 0; i < s.Length-1; i++)
            {
                for(int j = i+1; j < s.Length; j++)
                {
                    if (s.Substring(i, 1) == s.Substring(j, 1))
                    {
                        count++;
                        if(count > finalCount)
                        {
                            finalCount = count;
                           
                        }
                    }
                    
                }
                count = 0;
            }

           for(int i = 1; i <= finalCount; i++)
            {
                letters += "abcdefghijklmnopqrstuvwxyz";
            }
           for (int i = 0; i < s.Length; i++)
            {
                letters = letters.Remove(letters.LastIndexOf(s.Substring(i, 1)), 1);
            }
            char[] lettersArr = letters.ToCharArray();
            Array.Sort(lettersArr);
            letters = new string(lettersArr);
            
     
            return letters;
            

        }
            static void Main(string[] args)
        {
            Console.Write(MissingAlphabets("codewars"));
            Console.ReadKey();
        }
    }
}
