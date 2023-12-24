using Microsoft.AspNetCore.Mvc;
using MvcUI.Models;
using System.Diagnostics;

namespace MvcUI.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

     
    }
}