using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class DuplicateEncoder
    {

        public static  string ReturnDuplicate( string s)
        {
            //s = s.ToLower();
            //StringBuilder answer = new StringBuilder();

            //for(int index = 0;index < s.Length; index++)
            //{
            //    char reserved = s[index];

            //    if (!s.Remove(index, 1).Contains(reserved))
            //    {
            //        answer.Append('(');
            //    }
            //    else
            //    {
            //        answer.Append(')');
            //    }
            //}

            //return answer.ToString();


            // OR


            //var ans = new StringBuilder();
            //foreach (var c in (s = s.ToLower())) ans.Append(s.Remove(s.IndexOf(c), 1).Contains(c) ? ')' : '(');
            //return ans.ToString();
        }
        static void Main(string[] args)
        {
            Console.Write( ReturnDuplicate("Strterss"));
            Console.ReadKey();
        }
    }
}
