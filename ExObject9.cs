using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ExObject9
    {/// <summary>
    /// is palindrome if 1 letter is remove
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
        static string GetPalindrome(string s)
        {

            string palindrome = "OK";
            string copy = "";
            for (int i = 0; i < s.Length/2; i++)
            {
                if(s.Substring(i,1) != s.Substring(s.Length - 1 - i, 1))
                {
                    palindrome = "remove one";
                    copy = s;
                    break;
                }
            }

            bool isPalindrome = true;
            if (palindrome == "remove one")
            {
                for (int i = 0; i < s.Length; i++)
                {

                    s = s.Remove(i, 1);

                    for(int j = 0; j< s.Length / 2; j++)
                    {
                         if(s.Substring(j,1) != s.Substring(s.Length-1-j,1) && i == s.Length)
                        {
                            palindrome = "not possible";
                            isPalindrome = false;
                            break;
                        }
                       else if (s.Substring(j, 1) != s.Substring(s.Length - 1 - j, 1))
                        {
                            isPalindrome = false;
                            break;
                        }
                        else
                            isPalindrome = true;
                    }
                    if (isPalindrome)
                        break;
                    else                    
                    s = copy;
         
                }

            }

            return palindrome;
              
     
        /*        for (int i = s.Length; i > 0; i--)
            {
                palindrome += s.Substring(i-1, 1);
            }

            if(palindrome == s)
            {
                return "OK";
            }
            else if((palindrome.Remove(0,1)) == (s.Remove(s.Length-1,1)))
            {
                return "REMOVE ONE";
            }
            else
            {
                return "NOT POSSIBLE!";
            }*/
        
        }
        static void Main(string[] args)
        {
          Console.Write(GetPalindrome("mafaama"));
            Console.ReadKey();
        }
    }
}
