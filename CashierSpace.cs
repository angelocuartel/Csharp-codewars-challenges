using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class CashierSpace
    {
        public static string GetOrder(string input)
        {
            string newInput = "";
           while(input != string.Empty)
                switch (input.Substring(0,1))
                {
                    case "b":
                        newInput += "Burger ";
                        input = input.Remove(0,6);                        
                        break;
                    case "f":
                        newInput += "Fries ";
                        input = input.Remove(0, 5);
                        break;
                    case "c":
                        if (input.Substring(1, 1) == "o")
                        {
                            newInput += "Coke ";
                            input = input.Remove(0, 4);
                        }
                        else
                        {
                            newInput += "Chicken ";
                            input = input.Remove(0, 7);
                        }
                        break;
                    case "p":
                        newInput += "Pizza ";
                        input = input.Remove(0, 5);
                        break;
                    case "s":
                        newInput += "Sandwich ";
                        input = input.Remove(0, 8);
                        break;
                    case "o":
                        newInput += "Onionrings ";
                        input = input.Remove(0, 10);
                        break;
                    case "m":
                        newInput += "Milkshake ";
                        input = input.Remove(0, 9);
                        break;
                    default:
                        newInput += "";
                        break;
                }

            string[] order = { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };

            int countSpace = 1;
            for(int i = 0; i < newInput.TrimEnd().Length; i++)
            {
                if (newInput[i] == ' ')
                    countSpace++;
            }
           
            string[] newOrder = new string[countSpace];
            for (int i = 0; i < newOrder.Length; i++)
            {
                newOrder[i] = newInput.Substring(0, newInput.IndexOf(" "));
                newInput = newInput.Remove(0,newInput.IndexOf(" ")+1);
            }
            int sortCount = 0;
            string[] sortedOrder = new string[countSpace];
                for (int i = 0; i < order.Length; i++)
            {
               
                for(int j = 0;  j < newOrder.Length; j++)
                {
                    if (order[i] == newOrder[j])
                    {
                        sortedOrder[sortCount] = order[i];
                        sortCount++;
                       
                    }
                }
                
            }
             newInput = string.Empty;
            for (int i = 0; i < sortedOrder.Length; i++)
                newInput += sortedOrder[i]+" ";

            newInput = newInput.TrimEnd();
            return newInput;
        }

        static void Main(string[] args)
        {
            Console.Write(GetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"));
            Console.ReadKey();
        }
    }
}
