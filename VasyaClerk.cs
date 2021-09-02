using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class VasyaClerk
    {
        static string Tickets(int[] money)
        {
            List<int> storage = new List<int>();

            string canChange = "YES";
            for (int i = 0; i < money.Length; i++)
            {
                if (money[i] == 25)
                {
                    storage.Add(25);
                }
                else if (money[i] == 50)
                {
  
                        if (storage.Contains(25))
                        {
                            storage.Remove(25);
                            storage.Add(50);
                        }
                        else
                        {
                            canChange = "NO";
                            break;
                        }
                    
                }
                else
                {
                    if (storage.Contains(25) && storage.Contains(50))
                    {
                        storage.Remove(25);
                        storage.Remove(50);
                        storage.Add(100);
                    }
                    else
                    {
                        canChange = "NO";
                        break;
                    }

                }
            }
            return canChange;
        }

        static void Main(string[] args)
        {
            int[] input = {25,100};
            Console.Write(Tickets(input));
            Console.ReadKey();
        }
    }
}
