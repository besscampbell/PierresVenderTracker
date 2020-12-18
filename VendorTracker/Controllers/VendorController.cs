using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendList = Vendor.GetAll();
            return View(vendList);
        }
    }
}