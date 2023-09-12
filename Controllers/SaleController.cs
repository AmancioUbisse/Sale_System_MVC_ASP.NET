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
    }
}
