using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class TrafficLights
    {
        public static string[] GetTrafficLights(string road, int n)
        {
            road = road += '.';
            List<string> roads = new List<string>();
            var hasOrange = false;
            bool isStop = false;

            int next = 0;
            int r = 1, g = 1, o = 0;
            bool hasG = false;

            for (int i = 0; i <= n; i++)
            {

                roads.Add(road.Remove(road.Length-1,1));
             
                    if (g == 5)
                    {
                        o++;
                        g = 0;
                        road = road.Replace('G', 'O');
                    }
                    else if (o == 1 && r == 1)
                    {

                        r--;
                        road = road.Replace('O', 'R');
                        o--;

                    }

                    else if (o == 1 && r > 1)
                    {
                        hasOrange = true;
                        o--;
                    }

                    if (r == 5)
                    {
                        r = 0;
                        if (hasOrange)
                        {
                            road = road.Replace('R', 'G').Replace('O', 'R');
                            hasOrange = false;
                            g--;
                        }
                        else road = road.Replace('R', 'G');
                    }


              

                 if  (next != road.Length -1)
                {

                    if (road[next + 1] == 'G')
                    {
                        road = road.Remove(next, 2).Insert(next, ".C");
                        next++;

                        hasG = true;

                    }


                    else if (road[next + 1] == '.')
                    {

                        road = road.Remove(next, 2).Insert(next, ".C");
                        next++;
                       
                        if (isStop && g > 0)
                        {
                            road = road.Remove(next - 1, 1).Insert(next - 1, "G");
                            isStop = false;
                            hasG = false;

                        }

                        else if (hasG && o > 0)
                        {
                            road = road.Remove(next - 1, 1).Insert(next - 1, "O");
                            hasG = false;
                        }
                        else if (hasG)
                        {
                            road = road.Remove(next - 1, 1).Insert(next - 1, "G");
                            hasG = false;
                        }


                    }

                    else isStop = true;


                }

              


                
           
               

                r++;
                g++;
            }

            return roads.ToArray();
          

        
        }
        static void Main(string[] args)
        {

            foreach (var item in GetTrafficLights("CG..G", 10)) Console.WriteLine(item);
            Console.ReadKey();
        }



    
   
    }
}
