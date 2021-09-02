using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class IntParse2Reloaded
    {
        public static string IntParse(string words)
        {
            words = words.Replace("-", " ").Replace(" and "," ").Replace("   "," ");
            words += " ";
            StringBuilder numbers = new StringBuilder();
            StringBuilder spaceNum = new StringBuilder();
            Dictionary<string, string> dicNumbers = new Dictionary<string, string>()
            {
              
                {"one","1" },
                {"two","2" },
                {"three","3"},
                {"four","4" },
                {"five","5" },
                {"six","6" },
                {"seven","7" },
                {"eight","8" },
                {"nine","9" },
                {"ten","10" },
                {"eleven","11" },
                {"twelve","12" },
                {"thirteen","13" },
                {"fourteen","14" },
                {"fifteen","15" },
                {"sixteen","16" },
                {"seventeen","17" },
                {"eighteen","18" },
                {"nineteen","19" },
                {"twenty","20" },
                {"thirty","30" },
                {"forty","40" },
                {"fifty","50" },
                {"sixty","60" },
                {"seventy","70" },
                {"eighty","80" },
                {"ninety","90" },
                {"hundred","00" },
               {"thousand","000" },
                {"million","000000" }
            };
            while(words!= string.Empty)
            {
                    numbers.Append(dicNumbers[words.Substring(0,words.IndexOf(' '))]+" ");
                    words = words.Remove(0, words.IndexOf(' ') + 1);
            }
           int countSpace = 0;
            foreach(char letter in numbers.ToString())
            {
                if (letter == ' ')
                    countSpace++;
            }
            string[] values = new string[countSpace];
            for(int i = 0;i < countSpace; i++)
            {
                values[i] = numbers.ToString().Substring(0, numbers.ToString().IndexOf(' '));
                numbers = numbers.Remove(0,numbers.ToString().IndexOf(' ')+1);
            }

            string result =  "0";
            for(int i = 0; i< countSpace; i++)
            {
                if (i != countSpace - 1)
                {
                    if (values[i] == "000")
                        result += values[i];
                    else if (values[i] != "000" && values[i] != "00" && values[i + 1] == "00")
                    {
                        result = (int.Parse(result) + int.Parse((values[i] + values[i + 1]))).ToString();
                        i++;
                    }
                    else
                        result = (int.Parse(result) + int.Parse(values[i])).ToString();
                }
                else
                {
                    if (values[i] != "000" && values[i] != "00" && values[i]!="000000")
                        result = (int.Parse(result) + int.Parse(values[i])).ToString();
                    else if (values[i] == "000" || values[i] =="000000")
                        result += values[i];
                    else
                        result = (int.Parse(result) + int.Parse(result.Substring(result.Length-1,1)+values[i])).ToString();
                }


            }


            return result;
        }
       

            static void Main(string[]args)
             {
            Random numbers = new Random();
            Console.Write(IntParse("one million"));
            Console.ReadKey();
             }
        
    }
}
