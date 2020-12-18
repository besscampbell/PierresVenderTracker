using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VenderTracker.Models;

namespace VenderTrackerTests
{
    [TestClass]
    public class VenderTests
    {
        [TestMethod]
        public void VenderConstructor_CreatesInstanceOf_Vender()
        {
            Vender suzies = new Vender("Suzies Cafe");
            Assert.AreEqual(typeof(Vender), suzies.GetType);
        }
    }
}