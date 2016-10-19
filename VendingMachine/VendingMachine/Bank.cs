using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{   
    //this class will handle all money transactions
    class Bank
    {
        private Dictionary<string, decimal> _coins = new Dictionary<string, decimal>()
        {
            {"penny", 0.01m },
            {"nickel", 0.05m },
            {"dime", 0.10m },
            {"quarter", 0.25m}
        };

        //current amount for the customer
        private decimal currentAmount = 0;

        //amount of coins the vending machine has
        private int quarters = 0;
        private int nickels = 0;
        private int dimes = 0;

        //Updates the customers current amount
        //updates the coins the machine has
        public void insertCoin(string coin)
        {
          
            if (_coins.ContainsKey(coin)){

                currentAmount += _coins[coin];
                switch (coin)
                {
                    
                    case "nickel":
                        nickels += 1;
                        break;
                    case "dime":
                        dimes += 1;
                        break;
                    case "quarter":
                        quarters += 1;
                        break;
                    

                    default:
                        Console.WriteLine("Invalid selection. Please insert nickel, dime, quarter");
                        break;

                }
            }
            else
            {
                //throw invalid here
                
            }

        }


        //empties the customers coins
        public void removeCoins()
        {
            while ( currentAmount > 0)
            {
                if (currentAmount >= 0.25m && quarters > 0)
                {
                    quarters -= 1;
                    currentAmount -= 0.25m;
                }
                else if (currentAmount >= 0.10m && dimes > 0)
                {
                    dimes -= 1;
                    currentAmount -= 0.10m;
                }
                else if (currentAmount >= 0.05m && nickels > 0)
                {
                    nickels -= 1;
                    currentAmount -= 0.05m;
                }
            }
        }


        //pressitem, it is already valid for an item to be removed. 
        public void pressItem(decimal itemAmount)
        {
            currentAmount -= itemAmount;
        }





        //get functions
        public int getNickels()
        {
            return nickels;
        }

        public int getDimes()
        {
            return dimes;
        }
        public int getQuarters()
        {
            return quarters;
        }

        public decimal getCurrentAmount()
        {
            return currentAmount;
        }

    }
}
