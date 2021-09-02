using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class AlphabetWars_Reinforces_massacre
    {

        public static string AlphabetWar(string[] reinforces, string[] airstrikes)
        {
            var afterMath = string.Empty;
            var battlefield = reinforces[0];
            int index = 1;
            for (int i = 0; i < airstrikes.Length; i++)
            {
                Console.WriteLine("before airstrike: " + battlefield);
                Console.WriteLine("bombs: " + airstrikes[i]);
                for (int j = 0; j < airstrikes[i].Length; j++)
                {

                    if (airstrikes[i][j] == '*' && j < 1)
                    {
                        battlefield = battlefield.Remove(0, 2).Insert(0, "__");
                    }
                    else if (airstrikes[i][j] == '*' && j == battlefield.Length -1)
                    {
                        battlefield = battlefield.Remove(battlefield.Length-3, 2).Insert(battlefield.Length - 2, "__");
                    }
                    else if (airstrikes[i][j] == '*' && j > 0 && j < battlefield.Length - 1)
                    {
                        battlefield = battlefield.Remove(j - 1, 3).Insert(j - 1, "___");
                    }
                }

                Console.WriteLine("after airstrike: "+battlefield);
                battlefield = ReinforceTheTrench(battlefield, ref reinforces);
                Console.WriteLine("reinforce battlefield: "+battlefield);
               
            }

            return battlefield;

        }


        static string ReinforceTheTrench(string currentSoldiers, ref string[] reinforcements)
        {
            int reinforcementLength = reinforcements.Length;

            for (int i = 0; i < currentSoldiers.Length; i++)
            {
               
                    if (currentSoldiers[i] == '_')
                    {
                        for (int next = 1; next < reinforcementLength; next++)
                        {
                           
                                if (reinforcements[next][i] != '_')
                                {
                            if (reinforcements[next][i] == 'v') Console.WriteLine("v confirmed!");
                                    currentSoldiers = currentSoldiers.Remove(i, 1).Insert(i, reinforcements[next][i].ToString());
                                    reinforcements[next] = reinforcements[next].Remove(i, 1).Insert(i, "_");
                            
                            Console.WriteLine("reinforcements: "+reinforcements[next]);
                            Console.WriteLine("reinforced soldiers: " + currentSoldiers);
                            break;
                                }
                            
                        }
                    }
                
            }
            return currentSoldiers;
            
        }

       

        static void Main(string[] args)
        {
          
            Console.WriteLine(AlphabetWar(new string[] { "rwgagqx", "zhfweyq", "qxqbuqv", "hovcumw", "sdekgkl" },new string[] { "         * ", "        *  ", "       *  *", "* * *      ", "* *   *   *", "           "}));
            Console.ReadKey();
        }
    }
}
