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
        IPostRepository repositoryPost;
        public HomeController(ILogger<HomeController> logger,
            ICacheHelper cacheHelper,
            IMenuRepository _repositoryMenu,
            IPostRepository _repositoryPost
            ) : base(cacheHelper)
        {
            repositoryMenu = _repositoryMenu;
            repositoryPost = _repositoryPost;
            _logger = logger;

            // upload file, anh : chua xu lo
            //_env = env;
            //_dir = _env.ContentRootPath + "\\wwwroot\\files\\upload\\common\\";
        }

        // Trang của Nam Anh : Start

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
        [Route("news")]
        public async Task<IActionResult> news()
        {
            // set language : chua xu li
            //string lang = await SetLanguage(); ViewBag.Lang = lang;

            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            List<Post> GetPost = await repositoryPost.List();
            ViewBag.Post = GetPost;
            return View();
        }
        [HttpGet]
        [Route("home/privacy")]
        public async Task<IActionResult> Privacy()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }

        [HttpGet]
        [Route("error404")]
        public async Task<IActionResult> Error404()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        // Trang mẫu : End

        // Trang của Quỳnh : Start
        public async Task<IActionResult> Majors()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }

        public async Task<IActionResult> SoftwareTechnology()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> Finance()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> InformationSecurity()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> HotelManagment()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> EnglishLanguage()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> JapaneseLanguage()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> Fee()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> Scholarship()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        public async Task<IActionResult> Contact()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        // Trang của Quỳnh : End

        [HttpGet]
        [Route("Introduce")]
        public async Task<IActionResult> Introduce()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
