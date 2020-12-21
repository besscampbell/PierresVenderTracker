using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendList = Vendor.GetAll();
            return View(vendList);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }
        
        [HttpPost("/vendors")]
        public ActionResult Create(string vendName, string bio = "")
        {
            Vendor newVendor = new Vendor(vendName, bio);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor choosenVendor = Vendor.Find(id);
            List<Order> vendorOrders = choosenVendor.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", choosenVendor);
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string title, DateTime orderDate, int pastryOrder, int breadOrder, int totalCost, string notes = "")
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor choosenVendor = Vendor.Find(vendorId);
            DateTime dateOnly = orderDate.Date;
            Order newOrder = new Order(title, dateOnly, pastryOrder, breadOrder, totalCost, notes);
            choosenVendor.AddOrder(newOrder);
            List<Order> vendorOrders = choosenVendor.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", choosenVendor);
            return View("Show", model);
        }

    }
}