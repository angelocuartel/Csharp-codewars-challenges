using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StringNumbersCalculation
    {

        static string Calculate(string s)
        {

            var query = string.Join(string.Empty,s.ToCharArray().Where(c => ((!char.IsLetter(c)) && c=='+' || c=='/' || c =='-' || c =='*' || c=='.'||  char.IsNumber(c))).ToList());

            var nums = query.Split('*', '/', '+', '-');

            if (query.Contains("*")) return Math.Round(double.Parse(nums[0]) * double.Parse(nums[1])).ToString();
            else if (query.Contains("+")) return Math.Round(double.Parse(nums[0]) + double.Parse(nums[1])).ToString();
            else if (query.Contains("/")) return Math.Round(double.Parse(nums[0]) / double.Parse(nums[1])).ToString();
            else return Math.Round(double.Parse(nums[0]) - double.Parse(nums[1])).ToString();



        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(@"3gNZ9MJ4jlWSD1]a0.K^GvEMWXvYS2\aqPwEOGvnZuNmgwpQ6_08tqKjpf__XZ\jM]FvZpZVC1hgPe\DTJIrjcZ3U0Ufed3tdaTiZl6Rfv1*3HiK5K7Rk__P8_RC[\QCscq0Kl.vn66L^SF_vijf7AJ4UK]7AtM`GUmcELYr9gbj0479
"));
            Console.ReadKey();
        }
    }
}
