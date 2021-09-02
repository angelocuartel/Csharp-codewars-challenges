using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class ExArray14
    {
        public static void Main(string[] args)
        {
            string[,] array =
                {
                {"h","d","w" },
                {"l","h","w"},
                {"c","f","w"}
            };

            int equals = 1,finalEquals = 0;

            string holder = "";

            for(int col = 0; col < array.GetLength(1); col++)
            {
                for(int row = 1; row <= array.GetLength(0)-1; row++)
                {
                        if(array[row-1,col] == array[row, col])
                        {
                            equals++;
                            if(equals > finalEquals)
                            {
                                finalEquals = equals;
                                holder = array[row - 1, col];

                                if(row == array.GetLength(0) - 1)
                            {
                                equals = 1;
                            }
                        }
                        }
                    else
                    {
                        equals = 1;
                    }

                }
            }




            // for diagonal 
            int equalsD = 1, finalEqualsD = 0;

            string holderD = "";
        for(int col = 0; col < array.GetLength(0); col++)
            {
                int tempCol = col;
                for(int row = 1; row <= array.GetLength(1)-1; row++)
                {
                    if (tempCol == array.GetLength(0) - 1)
                    {
                        break;
                    }
                    else
                    {
                        if (array[row - 1, tempCol] == array[row, tempCol + 1])
                        {
                            equalsD++;

                            if(equalsD > finalEqualsD)
                            {
                                finalEqualsD = equalsD;
                                holderD = array[row - 1, tempCol];
                                if (row == array.GetLength(0) - 1)
                                {
                                    equalsD = 1;
                                }
                            }
                        }


                        tempCol++;
                    }
                }
            }



            Console.WriteLine(finalEquals > finalEqualsD ? "{0}\n{1} times (vertical)": "{2}\n{3} times (Diagonal)",holder,finalEquals,holderD,finalEqualsD);
            Console.ReadKey();




        }
         

        }
    }

