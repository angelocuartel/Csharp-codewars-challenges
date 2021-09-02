using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Mumbling
    {
        public static String Accum(string s)
        {
            s = s.ToLower();
            var ans = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                ans.Append(s[i], i + 1);
                ans.Append('-');
                ans = ans.Replace($"-{s[i]}", $"-{char.ToUpper(s[i])}");
            }

            return $"{ans.ToString().Substring(0, 1).ToUpper()}" + ans.ToString().Remove(0, 1).Remove(ans.Length - 2, 1);
        }
    }
}
