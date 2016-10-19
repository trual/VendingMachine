using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{   
    //this class handles all things dealing with inventory.
    class Inventory
    {
        public Dictionary<string, decimal> items = new Dictionary<string, decimal>()
        {
            {"cola", 1.00m },
            {"chips", 0.50m },
            {"candy", 0.65m }
        };

        //item inventory
        private int colas = 1;
        private int numberOfChips = 1;
        private int candies = 1;

        //returns true and removes a item if available
        public bool pressItem(string item, decimal currentAmount)
        {
            if (currentAmount >= items[item])
            {
                switch (item)
                {

                    case "cola":
                        colas -= 1;
                        break;
                    case "chips":
                        numberOfChips -= 1;
                        break;
                    case "candy":
                        candies -= 1;
                        break;


                    default:
                        Console.WriteLine("Invalid selection. Please press chips, candy, cola");
                        break;

                }

                return true;
            }
            else return false; 
           
        }


        public int getQuantity(string item)
        {
            switch (item)
            {

                case "cola":
                    return colas;
                    
                case "chips":
                    return numberOfChips;
                    
                case "candy":
                    return candies;
                  


                default:
                    Console.WriteLine("Invalid selection. Please press chips, candy, cola");
                    break;

            }
            return 0;
        }




    }
}
