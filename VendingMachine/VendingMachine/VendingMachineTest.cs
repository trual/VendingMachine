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
            Assert.AreEqual(0.25m, VM.insertCoin("quarter"));
        }
    }
}

