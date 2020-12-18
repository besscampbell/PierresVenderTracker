using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTrackerTests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOf_Vonder()
        {
            Vendor suzies = new Vendor("Suzies Cafe");
            Assert.AreEqual(typeof(Vendor), suzies.GetType());
        }

        [TestMethod]
        public void GetVendorName_ReturnsVendorName_String()
        {
            //Arrange
            string vendName = "Suzie's Cafe"
            Vendor suzies = new Vendor(vendName);
            //Act
            string result = suzies.Name;
            //Assert
            Assert.AreEqual(result, vendName);
        }
    }
}