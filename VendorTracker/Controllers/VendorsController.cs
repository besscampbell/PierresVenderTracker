using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    }
}