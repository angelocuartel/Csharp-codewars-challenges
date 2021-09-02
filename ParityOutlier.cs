using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ParityOutlier
    {
        public static int Find(int[] integers)
        {
            int odd = 0, even = 0;
            foreach (int n in integers) if (n % 2 == 0) even++; else odd++;

            return odd > even ? integers.Where(c => c % 2 == 0).SingleOrDefault() : integers.Where(c => c % 2 != 0).SingleOrDefault();
        }



        static void Main(string[] args)
        {
            Console.WriteLine(Find(new int[] {13,7,9,8,11 }));
            Console.ReadKey();
        }

    }


}
