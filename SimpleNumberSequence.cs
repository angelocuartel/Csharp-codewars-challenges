using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingGround
{
    class SimpleNumberSequence
    {
       public static int GetMissing(string numbers)
        {
        
            bool isComplete = false; double missing = -1;string reserveNum =string.Empty;
            int length = numbers.Length / 2, mod = length % length, lengthNum = 0;
            while (length > 0)
            {
                if (isComplete||missing != -1) break;
                 else 
                {
                    for (int index = 0; index < (numbers.Length - mod)-length; index += length)
                    {
                        if (numbers.Substring(index, length) == "99" || numbers.Substring(index, length) == "999" || numbers.Substring(index, length) == "9999" || numbers.Substring(index, length) == "99999")
                        {
                            lengthNum = numbers.Substring(index, length).Length + 1;
                            reserveNum += "0" + numbers.Substring(index, length);
                            numbers = reserveNum + numbers.Substring(index + length);
                            for (int i = 0; i < numbers.Length - lengthNum; i += lengthNum)
                                if (double.Parse(numbers.Substring(i, lengthNum)) == double.Parse(numbers.Substring(i + lengthNum, lengthNum)) - 2)
                                    missing = missing == -1 ? double.Parse((numbers.Substring(i, lengthNum))) + 1 : -1;
                            break;
                        }
                        else if (double.Parse(numbers.Substring(index, length)) == double.Parse(numbers.Substring(index + length, length)) - 2)
                            missing = missing == -1 ? double.Parse((numbers.Substring(index, length))) + 1 : -1;


                       if (double.Parse(numbers.Substring(index, length)) == double.Parse(numbers.Substring(index + length, length)) - 1) isComplete = true;
                       else isComplete = false;
                    }
                }
               
                length--;
            }
            return (int)missing;
        }
        
        static void Main(string[] args)
        {
   Console.Write(GetMissing("9899101102"));
         
            Console.ReadKey();
        }
    }
}
