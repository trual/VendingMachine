using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class VendingMachine
    {
        Bank bank = new Bank();

        public decimal insertCoin()
        {
           return bank.insertCoin();
        }
    }
}

   
