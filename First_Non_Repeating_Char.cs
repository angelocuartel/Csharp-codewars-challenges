using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TrainingGround
{
    class First_Non_Repeating_Char
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            var ans = string.Empty;
            
            for(int i = 0;i < s.Length;i++)
            {
                var r = s[i];

                if (!s.Remove(i,1).Contains(r))
                {
                    ans = r.ToString();
                    break;
                }
            }

            return ans;
        }
    
    static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingLetter("stress"));

          
            Console.ReadKey();
        }
    }
}
