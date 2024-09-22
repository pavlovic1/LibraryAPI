using LibraryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
