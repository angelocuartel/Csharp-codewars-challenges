using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SplitString
    {
    
        public static string[] GetSplit(string s)
        {

      
                for(int i = 0; i < s.Length; i += 3)
                {
                    s = s.Insert(i,",");
                }


            var item = s.Remove(0,1).Split(',');


            return s.Length % 2 == 0 ? s.Remove(0, 1).Split(',') : s.Remove(0, 1).Insert(s.Length - 1, "_").Split(',').ToArray(); 
        }

        static void Main(string[] args)
        {
             GetSplit("abcdef");
            Console.ReadKey();
        }
    }
}
