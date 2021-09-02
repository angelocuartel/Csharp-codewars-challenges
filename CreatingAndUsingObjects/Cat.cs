using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround.CreatingAndUsingObjects
{
    public class Cat
    {
        public string CatName { get; set; }
        public string CatSn { get; set; }

        public void SayMeow()
        {
            Console.WriteLine($"{CatName}{CatSn} meoww");
        }
    }
}
