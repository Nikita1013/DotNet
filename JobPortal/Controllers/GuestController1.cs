using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class GuestController1 : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Career()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }


    }
}
