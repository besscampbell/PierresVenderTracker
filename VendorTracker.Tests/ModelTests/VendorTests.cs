using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTrackerTests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }
        
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
            string vendName = "Suzie's Cafe";
             string vendBio = "Open for breakfast and lunch";
            Vendor suzies = new Vendor(vendName, vendBio);
            //Act
            string result = suzies.Name;
            //Assert
            Assert.AreEqual(result, vendName);
        }

        [TestMethod]
        public void GetId_ReturnVendorById_Int()
        {
            //Arrange=
            string vendName = "Suzie's Cafe";
             string vendBio = "Open for breakfast and lunch";
            Vendor suzies = new Vendor(vendName, vendBio);
            //Act
            int result = suzies.Id;
            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void GetAll_ReturnsAllInstancesOfVendor_VendorList()
        {
            //Arrange
            Vendor suzies = new Vendor("Suzie's Cafe", "Open for breakfast and lunch.");
            Vendor georgies = new Vendor("Georgie's Pizzeria", "Pizza pies flyin high");
            List<Vendor> vendList = new List<Vendor> { suzies, georgies };
            //Act
            List<Vendor> result = Vendor.GetAll();
            //Assert
            CollectionAssert.AreEqual(result, vendList);
        }

        [TestMethod]
        public void Find_ReturnVendorById_Vendor()
        {
           //Arrange
            Vendor suzies = new Vendor("Suzie's Cafe", "Open for breakfast and lunch.");
            Vendor georgies = new Vendor("Georgie's Pizzeria", "Pizza pies flyin high");
            //Act
            Vendor result = Vendor.Find(2);
            //Assert
            Assert.AreEqual(result, georgies); 
        }

        [TestMethod]
        public void GetVendorBio_ReturnVendorBio_String()
        {
            //Arrange
            string vendName = "Suzie's Cafe";
            string vendBio = "Open for breakfast and lunch";
            Vendor suzies = new Vendor(vendName, vendBio);
            //Act
            string result = suzies.Bio;
            //Assert
            Assert.AreEqual(result, vendBio);
        }

        [TestMethod]
        public void AddOrder_ConnectsTheOrderToTheVendor_OrderList()
        {
            DateTime date = new DateTime(2020,12,18);
            DateTime date2 = new DateTime(2020,12,24);
            Order newWorldOrder = new Order("title", date, 36, 24, 140, "notes");
            Order oldWorldOrder = new Order("title2", date2, 78, 10, 165, "notez");
            List<Order> orderList = new List<Order> { newWorldOrder, oldWorldOrder };
            string vendName = "Suzie's Cafe";
            string vendBio = "Open for breakfast and lunch";
            Vendor suzies = new Vendor(vendName, vendBio);
            suzies.AddOrder(newWorldOrder);
            suzies.AddOrder(oldWorldOrder);
            //Act
            List<Order> result = suzies.Orders;
            //Assert
            CollectionAssert.AreEqual(orderList, result);
        }
    }
}