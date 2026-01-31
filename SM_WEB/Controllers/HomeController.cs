using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace SM_WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

    }
}
