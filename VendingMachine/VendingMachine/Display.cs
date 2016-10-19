using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{   
    //this class determines what is on the display screen
    class Display
    {
        private string onScreen = "INSERT COIN";
        
        //updates what should be displayed
        public void updateDisplay(decimal currentAmount)
        {
            if (currentAmount == 0.0m)
            {
                onScreen = "INSERT COIN";
            }
            if (currentAmount > 0.0m)
            {
                onScreen = currentAmount.ToString();
            }
            
        }

        public string getDisplay()
        {
            return onScreen;
        }

        public void thankYou()
        {
            onScreen = "THANK YOU";

        }

        public void price(decimal item)
        {
            onScreen = item.ToString();
        }

        public void soldOut()
        {
            onScreen = "SOLD OUT";
        }

        public void invalidChoice()
        {
            onScreen = "Invalid Input";
        }
    }
}
