using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class VendingMachine
    {

        private Bank bank = new Bank();


        public void insertCoin(string coin)
        {
        
           bank.insertCoin(coin);
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
    }
}

   
