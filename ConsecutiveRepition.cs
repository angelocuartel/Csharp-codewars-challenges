using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ConsecutiveRepition
    {

        public static Tuple<char?,int> LongestRepition(string input)
        {
            if (input == string.Empty) return new Tuple<char?, int>(null, 0);
            else
            {
                char stopChar = ' ',lastChar =' ';
                int count = 1,lastCount = 0;

                for(int i = 0; i < input.Length; i++)
                {
                    if(stopChar != input[i])
                    {
                        stopChar = input[i];
                       for(int j = i +1; j < input.Length; j++)
                        {
                           if(input[i] == input[j])
                            {
                                count++;
                            }
                           else
                            {
                                break;
                            }
                        }


                        if (count > lastCount)
                        {
                            lastCount = count;
                            lastChar = input[i];
                            count = 1;

                        }
                        else count = 1;
                    }
                }

                return new Tuple<char?, int>(lastChar,lastCount);
            }
           
        }


        static void Main(string[] args)
        {
            Console.WriteLine(LongestRepition("bbbaaabaaaa"));
            Console.ReadKey();
        }
    }
}
