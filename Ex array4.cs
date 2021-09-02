using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Program
    {
      public static void Array4()
        {
          
        int[] array = {23,1,3,3,3,2,19,42,1,32,32,32,32,32,32,12,12,23, 23, 23, 23, 23, 23, 23, 23, 23, 23, 23 };

              int numEqual = 1,numSequence = 0;
              int finalNumEqual = 0, finalNumSeq = 0;

              for(int i = 0; i < array.Length - 1; i++)
              {

              if(array[i] == array[1 + i])
                  {
                      numEqual += 1;
                      numSequence = array[i];

                      if(numEqual > finalNumEqual)
                      {
                          finalNumEqual = numEqual;
                          finalNumSeq = numSequence;
                      }
                  }
              else
                  {
                      numEqual = 1;
                  }


              }

              for(int i = 0;  i < finalNumEqual; i++)
              {
                  Console.Write(finalNumSeq+" ");
              }


              Console.ReadKey();
         


         
        }
    }
}
