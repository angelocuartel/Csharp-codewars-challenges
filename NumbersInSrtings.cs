using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingGround
{
    class NumbersInSrtings
    {
        public static int Solve(string s)
        {
            foreach(char l in s)
            {
                if (char.IsLetter(l))
                    s = s.Replace(l,' ');
            }

            s = s.Trim();
            string copy = "";
            foreach(char l in s)
            {
                if (l != ' ')
                    copy += l;
                else if (copy.Substring(copy.Length-1,1) !=" ")
                    copy += " ";
            }
            int countSpace = 1;
            foreach(char l in copy)
            {
                if (l == ' ')
                    countSpace++;
            }
            int[] numbers = new int[countSpace];
            copy += " ";
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] =int.Parse(copy.Substring(0,copy.IndexOf(" ")+1));
                copy = copy.Remove(0,copy.IndexOf(" ") + 1);
            }
            Array.Sort(numbers);
            return numbers[numbers.Length - 1];
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Console.Write(Solve("gh12cdy695m1"));
            Console.ReadKey();
        }
    }
}
