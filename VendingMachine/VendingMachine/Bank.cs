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


        public int quarters = 0;

        public decimal insertCoin(string coin)
        {
          
            if (_coins.ContainsKey(coin)){
                return _coins[coin];
            }
            return 0.0m;
        }
    }
}
