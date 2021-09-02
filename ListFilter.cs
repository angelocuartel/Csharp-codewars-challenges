using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ListFilter
    {


        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> numbers = new List<int>();

            foreach (var item in listOfItems)
            

             if(item is int)
                {
                    Console.WriteLine(item);
                    numbers.Add((int)item);
                }
               
            return numbers;
        }


        static void Main(string[] args)
        {
            var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            Console.Write(GetIntegersFromList(list));
            Console.ReadKey();
        }
    }
}
