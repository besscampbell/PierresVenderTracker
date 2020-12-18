using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTests 
    {
        [TestMethod]
        public void OrderConstructor_CreateInstanceOf_Order()
        {
            Order newWorldOrder = new Order("title", "notes", "12/18/2020", 36, 24, 140);
            Assert.AreEqual(typeof(Order), newWorldOrder.GetType());

        }
    }
}