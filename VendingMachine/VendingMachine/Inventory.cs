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
        private Dictionary<string, decimal> _coins = new Dictionary<string, decimal>()
        {
            {"cola", 1.00m },
            {"chips", 0.50m },
            {"candy", 0.65m }
        };

        //item inventory
        private int numberOfCola = 1;

        //returns true and removes a item if available
        public bool pressItem(string item)
        {
            return true;
        }



    }
}
