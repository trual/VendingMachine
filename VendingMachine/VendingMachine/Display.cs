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
        

        public void updateDisplay(decimal currentAmount)
        {
            if (currentAmount == 0.0m)
            {
                onScreen = "INSERT COIN";
            }
            
        }

        public string getDisplay()
        {
            return onScreen;
        }
    }
}
