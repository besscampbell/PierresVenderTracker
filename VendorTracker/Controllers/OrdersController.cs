using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class OrdersController : Controller
    {

        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}
