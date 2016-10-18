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


        //Updates the customers current amount
        //updates the coins the machine has
        public void insertCoin(string coin)
        {
          
            if (_coins.ContainsKey(coin)){

                currentAmount += _coins[coin];
                switch (coin)
                {
                    case "quarter":
                        quarters += 1;
                        break;


                    default:
                        Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                        break;

                }
            }
            else
            {
                //throw invalid here
                
            }
            
        }

        public int getQuarters()
        {
            return quarters;
        }



    }
}
