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
        //keeps track of the inventory
        private Inventory inventory = new Inventory();

        //handles when a coin is inserted into the VM
        public void insertCoin(string coin)
        {
           bank.insertCoin(coin);
           display.updateDisplay(getCurrentAmount());
        }

        //return coins button
        //returns any coins in current amount
        //updates display
        public void returnCoin()
        {
            bank.removeCoins();
            display.updateDisplay(getCurrentAmount());
        }
       

        //press inventory items
        public void pressItem(string item)
        {
            if (inventory.getQuantity(item) != 0)
            {
                if (inventory.pressItem(item, getCurrentAmount()))
                {
                    //the item is inventory and has been removed
                    //now its time to remove the money from the bank
                    bank.pressItem(inventory.items[item]);
                    bank.removeCoins();
                    //sets on screen value to thankyou
                    display.thankYou();

                }
                else
                {
                    display.price(inventory.items[item]);
                }
            }
            else
            {
                display.soldOut();
            }
        }

        //returns the quatity in the ivnentory of the item
        public int getQuantity(string item)
        {
            return inventory.getQuantity(item);
        }


        //returns the display screen
        public string getDisplay()
        {
            return display.getDisplay();
        }

        //update display
        public void updateDisplay()
        {
            if (checkExactChange())
            {
                display.exactChange();
            }
            else {
                display.updateDisplay(getCurrentAmount());
            }
        }




        //get functions

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

        
        
        
        //check exact change
        //because or vending machine only takes coins there
        //will not be a senario where we owe > .20 without enough
        //coins to cover. Therefore our machine always needs
        //At least 4 nickels or a dime and 2 nickels.
        public bool checkExactChange()
        {
            if (getDimes() == 0 && getNickels() < 4)
            {
                //need exact change
                display.exactChange();
                return true;
            }
            else if (getNickels() < 2)
            {
                //need exact
                display.exactChange();
                return true;
            }
            return false;
        }
        
        
        
        //input

        public void takeInput(string input)
        {
            // need to check if coin
            if (bank.checkCoin(input))
            {
                insertCoin(input);
                display.updateDisplay(bank.getCurrentAmount());
            }
            // need to check if item
            else if (inventory.checkItem(input))
            {
                pressItem(input);
            }
            else if (input == "RETURN")
            {
                returnCoin();
            }
            else
            {
                //invalid choice
                display.invalidChoice();
            }
            // need to check if return coins
        }


    }
}

   
