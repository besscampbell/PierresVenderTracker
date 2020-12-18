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
            DateTime date = new DateTime(2020,12,18);
            date.ToString();
            Order newWorldOrder = new Order("title", date, 36, 24, 140, "notes");
            Assert.AreEqual(typeof(Order), newWorldOrder.GetType());

        }

        [TestMethod]
        public void OverloadedOrderConstructor_CreateInstanceNoNotes_Order()
        {
            DateTime date = new DateTime(2020,12,18);
            date.ToString();
            Order newWorldOrder = new Order("title", date, 36, 24, 140);
            Assert.AreEqual(typeof(Order), newWorldOrder.GetType());

        }
    }
}