using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class RemoveParenthesis
    {
       static string RemoveAllP(string s)
        {
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                count += s[i] == '(' ? 1 : 0;
                count -= s[i] == ')' ? 1 : 0;
                if (count > 0) { s = s.Remove(i, 1); i--; }
                
            }
            return s.Replace(")",string.Empty);

        }
    
        static void Main(string[] args)
        {
            Console.Write(RemoveAllP("hello(world) f (hello(sdf)ssafd(sdfw4rtgfh)sadfasdfsdf)sdfdsf"));
            Console.ReadKey();
        }
    }
}
