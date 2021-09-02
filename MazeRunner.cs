using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class MazeRunner
    {
        static string answer;
        public static string MazeDirection(string[] directions)
        {
            int[,] maze = new int[,] { { 1, 1, 1, 1, 1, 1, 1 },
                                       { 1, 0, 0, 0, 0, 0, 3 },
                                       { 1, 0, 1, 0, 1, 0, 1 },
                                       { 0, 0, 1, 0, 0, 0, 1 },
                                       { 1, 0, 1, 0, 1, 0, 1 },
                                       { 1, 0, 0, 0, 0, 0, 1 },
                                       { 1, 2, 1, 0, 1, 0, 1 } };

            int r =0,c =0;
            for(int i = 0; i < maze.GetLength(0); i++)
            {
                for(int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == 2)
                    {
                        r = i;
                        c = j;
                    }
                }
            }
            
          
            foreach(var cd in directions)
            {

                try
                {

                    if (cd == "N")
                    {
                        r--;
                        SetAnswer(maze[r, c]);

                    }
                    else if (cd == "W")
                    {
                        c--;
                        SetAnswer(maze[r, c]);
                    }
                    else if (cd == "S")
                    {
                        r++;
                        SetAnswer(maze[r, c]);
                    }
                    else
                    {
                        c++;
                        SetAnswer(maze[r, c]);
                    }
                    if (answer == "Finish" || answer == "Dead") break;
                }
                catch (IndexOutOfRangeException)
                {
                    answer = "Dead";
                    break;
                }
            }



            return answer;
        }

       
        static void SetAnswer(int mazePosition)
        {
            switch (mazePosition)
            {
                case 1:
                    answer = "Dead";
                    break;
                case 3:
              answer = "Finish";
                    break;
                case 0:
                    answer = "Lost";
                    break; 
                    
            }
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine(MazeDirection(new string[] { "N", "N", "N", "W","W"}));
            Console.ReadKey();
        }
    }
}
