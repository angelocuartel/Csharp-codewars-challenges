using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class RotationCipher
    {
        public static string Encode(int n, string s)
        {
            string sCopy = s;
    

            for (int times = 0; times < n; times++)
            {
                //Step 1 — remove all spaces:
                s = s.Replace(" ","");

                //  Step 2 — shift the order of string characters to the right by n:
                for (int i = 1; i <= n; i++)
                {
                    s = s.Insert(0, s.Substring(s.Length - 1, 1));
                    s = s.Remove(s.Length - 1, 1);
                    s.lastin
                }

                //Step 3 — place the spaces back in their original positions:
                for (int i = 0; i < sCopy.Length; i++)
                {
                    if (sCopy.Substring(i, 1) == " ")
                        s = s.Insert(i, " ");
                }
              /*  // count the spaces for creating array words
                int countSpace = 1;
                foreach (char letter in s)
                {
                    if (letter.ToString() == " ")
                        countSpace++;
                }
                // add a space for the s
                s += " ";
                string[] words = new string[countSpace];

                //adding every words in array string
                for (int i = 0; i < countSpace; i++)
                {
                    words[i] = s.Substring(0, s.IndexOf(" "));
                    s = s.Remove(0, s.IndexOf(" ") + 1);
                }

                //Step 4 — shift the order of characters for each space-separated substring to the right by n:
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        words[i] = words[i].Insert(0, words[i].Substring(words[i].Length -1, 1));
                        words[i] = words[i].Remove(words[i].Length - 1, 1);
                    }
                    s += words[i] + " ";
                }
                */
            } 
              
                s = s.Insert(0, n.ToString() + " ");
            // encoded string s
            return s;
        }
           




    public static string Decode(string s)
        {
            
            int n = int.Parse(s.Substring(0, s.IndexOf(" ")));
            s = s.Remove(0, s.IndexOf(" ")+1);
            string sCopy = s;
            for (int times = 1; times <= n; times++)
            {
                int countSpace = 1;
                foreach (char letter in s)
                {
                    if (letter.ToString() == " ")
                        countSpace++;
                }
                string[] words = new string[countSpace];
                s += " ";
                for (int i = 0; i < countSpace; i++)
                {
                    words[i] = s.Substring(0, s.IndexOf(" ")).TrimStart();
                    s = s.Remove(0, s.IndexOf(" ") + 1);
                }

                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        words[i] = words[i].Insert(words[i].Length, words[i].Substring(0, 1));
                        words[i] = words[i].Remove(0, 1);
                    }
                    s += words[i] + " ";
                }
                s = s.TrimEnd();
                s = s.Replace(" ", "");

                for (int i = 0; i < n; i++)
                {
                    s = s.Insert(s.Length, s.Substring(0, 1));
                    s = s.Remove(0, 1);
                }

                for (int i = 0; i < sCopy.Length; i++)
                {
                    if (sCopy.Substring(i, 1) == " ")
                        s = s.Insert(i, " ");
                }

            }
            return s;
        }
           

        static void Main(string[] args)
        {
            Console.Write(Encode(36, @"As I was going up the stair\nI met a man who wasn't there!\nHe wasn't there again today,\nOh how I wish he'd go away!"));
            //Console.Write(Decode(Encode(29, "I avoid that bleak first hour of the working day during which my still sluggish senses and body make every chore a penance.\nI find that in arriving later, the work which I do perform is of a much higher quality.")));

            Console.ReadKey();
        }
    }
}