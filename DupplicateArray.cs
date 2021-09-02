using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class DupplicateArray
    {
        static string dup(string[]arr)
        {
            List<string> dupStrings = new List<string>();


            for (int i = 0; i < arr.Length; i++)
            {
                dupStrings.Add("");
                for (int j = 0; j < arr[i].Length - 1; j++)
                {
                    if (dupStrings[i] == "")
                        dupStrings[i] += arr[i].Substring(j, 1);

                    if (dupStrings[i].Substring(dupStrings[i].Length-1, 1) != arr[i].Substring(j + 1, 1))
                    {
                        dupStrings[i] += arr[i].Substring(j+1, 1);
                    }

                }
            }
            return dupStrings[1];
        }
        static void Main(string [] args)
        {
            string[] val = { "abracadabra", "aaalllooottteee", "cccooodewards" };
            Console.WriteLine(dup(val));
            Console.ReadKey();
            
        }
    }
}
