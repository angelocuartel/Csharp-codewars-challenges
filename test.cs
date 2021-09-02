using System;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingGround
{
    class test
    {
     
       
       
        static void Main(string[] args)
        {
            CookRice();
            ReadyTable();

            Console.ReadKey();   
        }

        static async Task CookRice()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine("cooking rice");
                }
            });
            
        }


        static void ReadyTable()
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("preparing table");
            }
        }



    }   
           
  }
    

