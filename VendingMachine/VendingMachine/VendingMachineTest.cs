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
        }
    }
}

