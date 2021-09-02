using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class SimpleSequence
    {
      public static int GetMissingSeq(List<int> startingList, List<int> mixedList )
        {
            int missing = 0;
            foreach(int number in startingList)if(!mixedList.Contains(number)) missing = number;
            return missing;

        }
        static void Main(string[] args)
        {
            Console.Write(GetMissingSeq(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new List<int>() { 5, 7, 6, 9, 4, 8, 1, 2, 3 }));
            Console.ReadKey();
        }
    }
}
