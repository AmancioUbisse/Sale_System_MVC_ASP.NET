using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Sale_System.Models;
using System.Diagnostics;
namespace Sale_System.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Sales() {
        return View();
       }
        public IActionResult services()
        {
            return View();
        }

        public IActionResult Stock()
        {
            return View();
        }

        public IActionResult wallet()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult Registrations()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
    }
}
