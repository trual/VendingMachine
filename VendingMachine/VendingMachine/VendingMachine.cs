using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class VendingMachine
    {
        //keeps track of all money related things
        private Bank bank = new Bank();
        //keeps track of the display screen
        private Display display = new Display();

        //handles when a coin is inserted into the VM
        public void insertCoin(string coin)
        {
           bank.insertCoin(coin);
           display.updateDisplay(getCurrentAmount());
        }

        public int getNickels()
        {
            return bank.getNickels();
        }

        public int getDimes()
        {
            return bank.getDimes();
        }

        public int getQuarters()
        {
            return bank.getQuarters();
        }

        public decimal getCurrentAmount()
        {
            return bank.getCurrentAmount();
        }


        //returns the display screen
        public string getDisplay()
        {
            return display.getDisplay();
        }
    }
}

   
