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
        VendingMachine VM = new VendingMachine();

        //this will test wether or not we can accept a coin
        [TestMethod()]
        public void acceptACoin()
        {
            VM.insertCoin("quarter");
            Assert.AreEqual(1, VM.getQuarters() );
            Assert.AreEqual(0.25m, VM.getCurrentAmount());
        }
        [TestMethod()]
        public void acceptAnyCoin()
        {
            VM.insertCoin("nickel");
            Assert.AreEqual(1, VM.getNickels());
            Assert.AreEqual(0.05m, VM.getCurrentAmount());
            VM.insertCoin("dime");
            Assert.AreEqual(1, VM.getDimes());
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
            Assert.AreEqual(1, VM.getNickels());
            Assert.AreEqual(0.05m, VM.getCurrentAmount());
            Assert.AreEqual("0.05", VM.getDisplay());
            VM.insertCoin("dime");
            Assert.AreEqual(1, VM.getDimes());
            Assert.AreEqual(0.15m, VM.getCurrentAmount());
            Assert.AreEqual("0.15", VM.getDisplay());
        }

        //coin return
        [TestMethod()]
        public void returnMyQuarter()
        {
            VM.insertCoin("quarter");
            Assert.AreEqual(1, VM.getQuarters());
            Assert.AreEqual(0.25m, VM.getCurrentAmount());
            Assert.AreEqual("0.25", VM.getDisplay());
            VM.returnCoin();
            Assert.AreEqual(0.0m, VM.getCurrentAmount());
            Assert.AreEqual(0, VM.getQuarters());
            Assert.AreEqual("INSERT COIN", VM.getDisplay());

        }
    }
}

