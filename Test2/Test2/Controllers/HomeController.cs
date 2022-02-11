using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Daihoc_FPT_News.Models;

namespace Daihoc_FPT_News.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error400()
        {
            return View();
        }

        public IActionResult Majors()
        {
            return View();
        }

        public IActionResult SoftwareTechnology()
        {
            return View();
        }
        public IActionResult Finance()
        {
            return View();
        }
        public IActionResult InformationSecurity()
        {
            return View();
        }
        public IActionResult HotelManagment()
        {
            return View();
        }
        public IActionResult EnglishLanguage()
        {
            return View();
        }
        public IActionResult JapaneseLanguage()
        {
            return View();
        }
        public IActionResult Fee()
        {
            return View();
        }
        public IActionResult Scholarship()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
