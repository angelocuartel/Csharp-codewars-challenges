using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ExObject11
    {
        static string[] phrases = { "The product is excellent", "This is a great product", "I use this product constantly", "This is the best product from this catergory" };
        static string[] stories = { "Now I feel better.", "I managed to change.", "It made some miracle", "I can't believe it,but now I am feeling great","You should try it , too","I am very satisfied" };
        static string[] firstNames = {" Dayan "," stella "," hellen "," Kate "};
        static string[] lastNames = {"johnson","Peterson","Charles"};
        static string[] cities = {"London","Paris","Berlin","New York","Madrid"};

      static string RandomAds()
        {
     
            Random random = new Random();
            return phrases[random.Next(0, phrases.Length - 1)] +" "+ stories[random.Next(0,stories.Length-1)]+ " " + firstNames[random.Next(0,firstNames.Length-1)]+ " " + lastNames[random.Next(0, lastNames.Length - 1)]+ " " + cities[random.Next(0, cities.Length - 1)];
        }
       
      static void Main(string[] args)
        {
            Console.Write(RandomAds());
            Console.ReadKey();
        }

    }
}
