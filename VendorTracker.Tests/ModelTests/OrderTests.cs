using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }
        
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

        [TestMethod]
        public void GetProperties_ReturnOrderProperties_String()
        {
            //Arrange
            string title = "Order for Suzies";
            DateTime date = new DateTime(2020,12,18);
            date.ToString();
            string notes = "No delivery on Mondays";
            //Act
            Order result = new Order(title, date, 36, 24, 140, notes);
            //Arrange
            Assert.AreEqual(title, result.Title);
            Assert.AreEqual(date, result.Date);
            Assert.AreEqual(notes, result.Notes);
        }

        [TestMethod]
        public void GetIntProperties_ReturnOrderProperties_Int()
        {
            //Arrange
            int pastries = 36;
            int loaves = 24;
            int totalCost = 140;
            DateTime date = new DateTime(2020,12,18);
            date.ToString();
            //Act
            Order result = new Order("title", date, pastries, loaves, totalCost);
            //Assert
            Assert.AreEqual(pastries, result.PastryOrder);
            Assert.AreEqual(loaves, result.BreadOrder);
            Assert.AreEqual(totalCost, result.TotalCost);
        }

        [TestMethod]
        public void GetAll_ReturnAllInstancesOfOrder_OrderList()
        {
            //Arrange
            DateTime date = new DateTime(2020,12,18);
            DateTime date2 = new DateTime(2020,12,24);
            Order newWorldOrder = new Order("title", date, 36, 24, 140, "notes");
            Order oldWorldOrder = new Order("title2", date2, 78, 10, 165, "notez");
            List<Order> theList = new List<Order> { newWorldOrder, oldWorldOrder };
            //Act
            List<Order> result = Order.GetAll();
            //Assert
            CollectionAssert.AreEqual(theList, result); 
        } 

        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            //Arrange
            DateTime date = new DateTime(2020,12,18);
            DateTime date2 = new DateTime(2020,12,24);
            Order newWorldOrder = new Order("title", date, 36, 24, 140, "notes");
            Order oldWorldOrder = new Order("title2", date2, 78, 10, 165, "notez");
            //Act
            Order result = Order.Find(2);
            //Assert
            Assert.AreEqual(oldWorldOrder, result);
        }
    }
}