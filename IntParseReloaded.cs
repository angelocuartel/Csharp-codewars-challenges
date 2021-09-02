using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class IntParseReloaded
    {
     
            public static string Convert(int n)
        {
            string numbers = n.ToString();
            string words = string.Empty;
            int index = 0;
            string reserveNum = string.Empty;
            for(int i = numbers.Length; i != 0; i--)
            {
                if(numbers[index] != '0')
                {
                    if (i == 1)
                        words += GetOnes(int.Parse(numbers[index].ToString()));
                    else if (i == 2)
                    {
                        if (numbers[index] == '1' || int.Parse(numbers[index].ToString()) >= 2 && numbers[index + 1] == '0')
                        {
                            words += GetTens(int.Parse(numbers.Substring(index, 2)));
                            break;
                        }
                        else if (int.Parse(numbers[index].ToString()) >= 2 && numbers[index + 1] != '0')
                            words += GetTens(int.Parse(numbers.Substring(index, 2)) - int.Parse(numbers[index + 1].ToString())) + "-";
                    }
                    else if (i == 3)
                        words += GetOnes(int.Parse(numbers[index].ToString())) + " hundred ";
                    else if (i == 4)
                        words += GetOnes(int.Parse(numbers[index].ToString())) + " Thousand ";
                    else if (i == 5)
                    {
                        if (int.Parse(numbers[index].ToString()) >= 2 && numbers[index + 1] != '0')
                            words += GetTens(int.Parse(numbers.Substring(index, 2)) - int.Parse(numbers[index + 1].ToString())) + "-";
                        else
                        {
                            words += GetTens(int.Parse(numbers.Substring(index, 2))) + " Thousand ";
                            index++;
                            i--;
                        }
                    }
                    else if (i == 6)
                    {
                        if (numbers.Substring(1, 2) == "00")
                        {
                            words += GetOnes(int.Parse(numbers[index].ToString())) + " hundred Thousand ";
                            index += 2;
                            i -= 2;
                        }
                        else
                        {
                            words += GetHundreds(numbers.Substring(0, 3)) + " thousand ";
                            index += 2;
                            i -= 2;
                        }


                    }
                    
                }
                else if (numbers[index] == '0' && numbers.Length == 1) words += GetOnes(int.Parse(numbers[index].ToString()));
                index++;
            }
            return words.Trim();
        }

     public   static string GetHundreds(string numbers)
        {
            string words = string.Empty;
            int index = 0;
            for (int i = numbers.Length; i != 0; i--)
            {
                if (numbers[index] != '0')
                {
                    if (i == 1)
                        words += GetOnes(int.Parse(numbers[index].ToString()));
                    else if (i == 2)
                    {
                        if (numbers[index] == '1' || int.Parse(numbers[index].ToString()) >= 2 && numbers[index + 1] == '0')
                        {
                            words += GetTens(int.Parse(numbers.Substring(index, 2)));
                            break;
                        }
                        else if (int.Parse(numbers[index].ToString()) >= 2 && numbers[index + 1] != '0')
                            words += GetTens(int.Parse(numbers.Substring(index, 2)) - int.Parse(numbers[index + 1].ToString())) + "-";
                    }
                    else if (i == 3)
                        words += GetOnes(int.Parse(numbers[index].ToString())) + " hundred ";
                }
                index++;
            }
            return words.Trim();
        }
      public  static string GetOnes(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Invalid";
            }
       
        }

     public   static string GetTens(int number)
        {
         
            switch (number)
            {
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eightteen";
                case 19:
                    return "nineteen";
                case 20:
                    return "twenty";
                case 30:
                    return "thirty";
                case 40:
                    return "forty";
                case 50:
                    return "fifty";
                case 60:
                    return "sixty";
                case 70:
                    return "seventy";
                case 80:
                    return "eighty";
                case 90:
                    return "ninety";
                default:
                    return "Invalid";
            }


        }
        static void Main(string[]args)
        {
           
            Console.WriteLine(Convert(301));

            Console.ReadKey();
        }
    }
}
