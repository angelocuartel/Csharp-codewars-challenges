using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class OnesZeroes
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            StringBuilder dec = new StringBuilder();
            foreach (int num in BinaryArray) dec.Append(num);
            return Convert.ToInt32(dec.ToString(),2);
        }
    }
}
