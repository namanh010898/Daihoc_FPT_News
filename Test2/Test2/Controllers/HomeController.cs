using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Daihoc_FPT_News.Controllers;
using Daihoc_FPT_News.Models;
using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util;
//using Daihoc_FPT_News.ViewModel;

namespace Daihoc_FPT_News.Controllers
{
    public class HomeController : BaseController
    {

        private readonly ILogger<HomeController> _logger;

        IMenuRepository repositoryMenu;

        public HomeController(ILogger<HomeController> logger,
            ICacheHelper cacheHelper,
            IMenuRepository _repositoryMenu
            ) : base(cacheHelper)
        {
            repositoryMenu = _repositoryMenu;

            _logger = logger;

            // upload file, anh : chua xu lo
            //_env = env;
            //_dir = _env.ContentRootPath + "\\wwwroot\\files\\upload\\common\\";
        }

        // Trang mẫu : Start

        // trang homepage
        [HttpGet]
        [Route("")]
        [Route("home")]
        public async Task<IActionResult> Index()
        {
            // set language : chua xu li
            //string lang = await SetLanguage(); ViewBag.Lang = lang;

            string lang = "vi";

            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);

            return View();
        }

        [HttpGet]
        [Route("home/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [Route("error404")]
        public IActionResult Error404()
        {
            return View();
        }
        // Trang mẫu : End

        // Trang của Quỳnh : Start
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
        // Trang của Quỳnh : End

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
