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
using Newtonsoft.Json;
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
            ViewBag.MenuList = MenuList;
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = MenuListFooter;

            return View();
        }

        // trang su kien
        [HttpGet] 
        [Route("thu-vien")]
        public async Task<IActionResult> Event()
        {  
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);

            var HaveListEventAboutToStartSoon = 0;
            var listAllEvent = await repositoryPost.ListAllEvent();
            if (listAllEvent != null && listAllEvent.Count > 0)
            {
                ViewBag.listAllEvent = listAllEvent;
            }

            

            List<Post> listPostEventAboutToStartSoon = new List<Post>();
            if (listAllEvent != null && listAllEvent.Count > 0)
            {
                for (int i = 0; i < listAllEvent.Count; i++)
                {
                    if (DateTime.Now < listAllEvent[i].OpenTime)
                    {
                        listPostEventAboutToStartSoon.Add(listAllEvent[i]);
                    }
                }
                if (listPostEventAboutToStartSoon.Count > 0)
                {
                    HaveListEventAboutToStartSoon = 1;
                }
                ViewBag.listPostEventAboutToStartSoon = listPostEventAboutToStartSoon;
                ViewBag.listPostEventAboutToStartSoonJson = JsonConvert.SerializeObject(listPostEventAboutToStartSoon);
            }
            ViewBag.HaveListEventAboutToStartSoon = HaveListEventAboutToStartSoon;

            var HaveListEventsIsGoingOn = 0;
            var ListEventsIsGoingOn = await repositoryPost.ListEventsIsGoingOnPaging(1, 4);
            if (ListEventsIsGoingOn != null && ListEventsIsGoingOn.Count > 0)
            {
                HaveListEventsIsGoingOn = 1;
                ViewBag.ListEventsIsGoingOn = ListEventsIsGoingOn;
            }
            ViewBag.HaveListEventsIsGoingOn = HaveListEventsIsGoingOn;

            var HavelistEventsEnded = 0;
            var listEventsEnded = await repositoryPost.ListEventsEndedPaging(1, 4);
            if (listEventsEnded != null && listEventsEnded.Count > 0)
            {
                HavelistEventsEnded = 1;
                ViewBag.listEventsEnded = listEventsEnded;
            }
            ViewBag.HavelistEventsEnded = HavelistEventsEnded;

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
        [Route("search")]
        public async Task<IActionResult> Search()
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            return View();
        }
        [HttpGet]
        [Route("detail/{url}")]
        public async Task<IActionResult> PostDetail(string url)
        {
            string lang = "vi";
            List<Menu> MenuList = await repositoryMenu.ListMenuHeader();
            ViewBag.MenuList = NovaticUtil.ChangeMenuLanguage(MenuList, lang);
            List<Menu> MenuListFooter = await repositoryMenu.ListMenuFooter();
            ViewBag.MenuListFooter = NovaticUtil.ChangeMenuLanguage(MenuListFooter, lang);
            var split = url.Split("-");
            var id = split[0];
            var Post = await repositoryPost.Detail(Convert.ToInt32(id));
            ViewBag.Post = Post;
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
