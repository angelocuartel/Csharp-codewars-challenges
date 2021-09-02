using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ConsecutiveString
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || k > strarr.Length || k <= 0) return string.Empty;
            else
            {
                int length = 0;
                var ans = string.Empty;


                for (int i = 0; i < strarr.Length - (k-1); i++)
                {
                    var temp = new StringBuilder();
                    for (int j = i; j < i+k; j++) temp.Append(strarr[j]);

                    if (temp.Length > length)
                    {
                        length = temp.Length;
                        ans = temp.ToString();

                    }
                  
                }

                return ans;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsec(new string []{ "tree", "foling", "trashy", "blue", "abcdef", "uvwxyz"}, 2));
            Console.ReadKey();
        }
    }
}
