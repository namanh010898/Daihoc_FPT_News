﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Controllers
{
    public class PostLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
