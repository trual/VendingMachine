using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    [TestClass()]
    public class VendingMachineTest
    {


        int nickels;
        int dimes;
        int quarters;

        [TestInitialize]
        public void TestInitialize()
        {
            nickels = VM.getNickels();
            dimes = VM.getDimes();
            quarters = VM.getQuarters();
        }



        VendingMachine VM = new VendingMachine();

        //this will test wether or not we can accept a coin
        [TestMethod()]
        public void acceptACoin()
        {
            VM.insertCoin("quarter");
            Assert.AreEqual(quarters + 1, VM.getQuarters() );
            Assert.AreEqual(0.25m, VM.getCurrentAmount());
        }
        [TestMethod()]
        public void acceptAnyCoin()
        {
            VM.insertCoin("nickel");
            Assert.AreEqual(nickels + 1, VM.getNickels());
            Assert.AreEqual(0.05m, VM.getCurrentAmount());
            VM.insertCoin("dime");
            Assert.AreEqual(dimes + 1, VM.getDimes());
            Assert.AreEqual(0.15m, VM.getCurrentAmount());
        }
        //test initial display
        [TestMethod()]
        public void initialDisplayScreen()
        {
            Assert.AreEqual("INSERT COIN", VM.getDisplay());
        }

        [TestMethod()]
        public void updatedDisplayScreen()
        {
            
            VM.insertCoin("nickel");
            Assert.AreEqual(nickels + 1, VM.getNickels());
            Assert.AreEqual(0.05m, VM.getCurrentAmount());
            Assert.AreEqual("0.05", VM.getDisplay());
            VM.insertCoin("dime");
            Assert.AreEqual(dimes + 1, VM.getDimes());
            Assert.AreEqual(0.15m, VM.getCurrentAmount());
            Assert.AreEqual("0.15", VM.getDisplay());
        }

        //coin return
        [TestMethod()]
        public void returnMyQuarter()
        {
            VM.insertCoin("quarter");
            Assert.AreEqual(quarters + 1, VM.getQuarters());
            Assert.AreEqual(0.25m, VM.getCurrentAmount());
            Assert.AreEqual("0.25", VM.getDisplay());
            VM.returnCoin();
            Assert.AreEqual(0.0m, VM.getCurrentAmount());
            Assert.AreEqual(quarters, VM.getQuarters());
            Assert.AreEqual("INSERT COIN", VM.getDisplay());

        }
        [TestMethod()]
        public void insertAndReturnNickelDimeQuarter()
        {
            VM.insertCoin("nickel");
            VM.insertCoin("dime");
            VM.insertCoin("quarter");
            Assert.AreEqual("0.40", VM.getDisplay());
            VM.returnCoin();
            Assert.AreEqual(0.0m, VM.getCurrentAmount());
            Assert.AreEqual("INSERT COIN", VM.getDisplay());

        }
        //press inventory buttons
        [TestMethod()]
        public void pressColaButton()
        {
            VM.insertCoin("quarter");
            VM.insertCoin("quarter");
            VM.insertCoin("quarter");
            VM.insertCoin("quarter");
            VM.pressItem("cola");
            Assert.AreEqual(0, VM.getQuantity("cola"));
        }

        [TestMethod()]
        public void buySomeCandyAndGetYourMoneyReturned()
        {
            VM.insertCoin("quarter");
            VM.insertCoin("quarter");
            VM.insertCoin("dime");
            VM.insertCoin("dime");
            VM.pressItem("candy");
            Assert.AreEqual(0, VM.getQuantity("candy"));
            Assert.AreEqual(0.0m, VM.getCurrentAmount());

        }

        [TestMethod()]
        public void buySomeChipsAndGetYourMoneyReturned()
        {
            VM.insertCoin("quarter");
            VM.insertCoin("dime");
            VM.insertCoin("dime");
            VM.insertCoin("dime");
            VM.pressItem("chips");
            Assert.AreEqual(0, VM.getQuantity("chips"));
            Assert.AreEqual(0.0m, VM.getCurrentAmount());
            Assert.AreEqual("THANK YOU", VM.getDisplay());

        }

        [TestMethod()]
        public void insuffcientFundsMustInsertAdditionalPylons()
        {
            VM.insertCoin("quarter");
            VM.insertCoin("dime");
            VM.insertCoin("dime");
            VM.insertCoin("dime");
            VM.pressItem("cola");
            Assert.AreEqual(1, VM.getQuantity("cola"));
            Assert.AreEqual(0.55m, VM.getCurrentAmount());
            Assert.AreEqual("1.00", VM.getDisplay());
        }

    }
}

