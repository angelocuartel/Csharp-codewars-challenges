using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class FindDuplicates
    {


        static int CountDuplicates(string s)
        {
            s = s.ToLower();
            var c = s;
            int ans = 0;
            var recent = new StringBuilder();

           for(int i = 0; i < c.Length-1;i++)
            {

                if ((s.Remove(0, i + 1)).Contains(c[i]) && !recent.ToString().Contains(c[i]))
                {
                    recent.Append(c[i]);
                    ans++;
                }

            


            }
            return ans ;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CountDuplicates("Indivisibilities"));
            Console.ReadKey();
        }
    }
}
