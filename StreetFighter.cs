using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class StreetFighter
    {

        public static string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {
            List<string> selectedFighters = new List<string>();


            foreach(var move in moves)
            {

                if (position[1] == 0 && move == "left")
                    position[1] = fighters[position[0]].Length - 1;
                else if (move == "up" && position[0] > 0)
                    position[0]--;
                else if (move == "down" && position[0] < fighters.Length - 1)
                    position[0]++;
                else if (position[1] == fighters[position[0]].Length - 1 && move == "right")
                    position[1] = 0;
                else if (move == "left")
                    position[1]--;
                else if (move == "right")
                    position[1]++;


                selectedFighters.Add(fighters[position[0]][position[1]]);
       
            }



        

            return selectedFighters.ToArray();
        }






        public static void Main(string[] args)
        {
            foreach (var item in StreetFighterSelection(new string[][] { new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega"}, new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" } }, new int[] {0,0 }, new string[] { "up", "left", "right", "left", "left" }))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
