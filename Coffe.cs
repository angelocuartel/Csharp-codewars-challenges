using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Coffe
    {

       static string HashTag(string s)
        {
            return $"#{s.Replace(" ", "")}";
        }
        static void Main(string[] args)
        {
            Console.Write(HashTag("We Unite As 1"));
            Console.ReadKey();
        }
    }
}
