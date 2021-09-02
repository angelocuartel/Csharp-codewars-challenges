using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class FinalNumSequence
    {

    static int GetMissing(string number)
        {
            int noDiv = number.Length / 2, noMod = number.Length % noDiv, missing = -1;
            bool  hasMissing = false;
            bool isComplete = true;
            int indexNum = 0;

            while(noDiv > 0)
            {
                noMod = number.Length % noDiv;
                for (int index = 0; index < number.Length - (noDiv + noMod); index += noDiv)
                {
                    indexNum += noDiv;
                    if (number.Substring(index, noDiv) == "99" || number.Substring(index, noDiv) == "999" || number.Substring(index, noDiv) == "9999" || number.Substring(index, noDiv) == "99999")
                    { 
                       CheckNine(ref missing, number.Substring(index, noDiv), number.Substring(indexNum));
                        hasMissing = true;
                        break;
                    }
                   else if((number.Substring(index, noDiv) == "98" || number.Substring(index, noDiv) == "998" || number.Substring(index, noDiv) == "9998" || number.Substring(index, noDiv) == "99998"))
                    {
                        CheckEight(ref missing, number.Substring(index, noDiv), number.Substring(indexNum));
                        break;
                    }


                   else if (double.Parse(number.Substring(index, noDiv)) == double.Parse(number.Substring(index + noDiv, noDiv)) - 2)
                    {
                        missing = missing == -1?int.Parse(number.Substring(index, noDiv)) + 1:-1;
                        hasMissing = true;
                    }
                    else if (double.Parse(number.Substring(index, noDiv)) != double.Parse(number.Substring(index + noDiv, noDiv)) - 1) isComplete = false;
                }

                if (hasMissing) break;
                else if (isComplete) break;

                indexNum = 0;
                isComplete = true;
                noDiv--;                                   
            }

            return missing;
        }

   static void CheckEight(ref int missingNo,string eight,string numbers)
        {
            if (int.Parse(eight) != int.Parse(numbers.Substring(0, eight.Length)) - 1)
            {
                missingNo = missingNo == -1 ? int.Parse(eight) + 1 : -1;
                CheckNine(ref missingNo, (int.Parse(eight) + 1).ToString(), numbers);
            }
            else CheckNine(ref missingNo, (int.Parse(eight) + 1).ToString(), numbers.Substring(eight.Length));
        }

        static void CheckNine(ref int missingNo,string nine,string numbers)
        {
            Console.WriteLine(nine+" "+numbers);
            string allNumbers = "0" + nine + numbers;
            for (int i = 0;i< allNumbers.Length - (nine.Length + 1); i += nine.Length + 1)
                if (long.Parse(allNumbers.Substring(i, nine.Length + 1)) == long.Parse(allNumbers.Substring(i + nine.Length + 1, nine.Length + 1)) - 2)
                    missingNo = missingNo == -1 ? int.Parse(allNumbers.Substring(i, (nine.Length + 1))) + 1 : -1;
        }

        static void Main(string[] args)
        {
       //  Console.WriteLine(GetMissing("123567"));
  //       Console.WriteLine(GetMissing("899091939495"));
          Console.WriteLine(GetMissing("9899101102"));
     //   Console.WriteLine(GetMissing("599600601602"));
        //   Console.WriteLine(GetMissing("8990919395"));
        //        Console.WriteLine(GetMissing("998999100010011003"));

         //      Console.WriteLine(GetMissing("99991000110002"));
        //        Console.WriteLine(GetMissing("979899100101102"));
         //      Console.WriteLine(GetMissing("900001900002900004900005900006"));

            Console.ReadKey();
        }
    }
}
