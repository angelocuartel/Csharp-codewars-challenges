using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingGround.CreatingAndUsingObjects;


namespace TrainingGround.ExObject7
{
    class MainClass
    {
        static void Main(string [] args)
        {
            Random randomNum = new Random();
            string[] catNames = {"tom","angela","hink","granger","ben","matthew","jason","penny","vanessa","george"};
            Cat[] myCat = new Cat[10];
           
          for(int i = 0; i < myCat.Length; i++)
            {
                myCat[i] = new Cat();
                myCat[i].CatName = catNames[i];
                myCat[i].CatSn = randomNum.Next(1, 100).ToString();
                myCat[i].SayMeow();
            }
            Console.ReadKey();
        }
    }
}
