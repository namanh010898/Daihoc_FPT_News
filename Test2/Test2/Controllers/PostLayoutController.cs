using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostLayoutController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        IPostLayoutRepository repositoryPostLayout;
        public PostLayoutController(ILogger<HomeController> logger,
            ICacheHelper cacheHelper,
            IPostLayoutRepository _repositoryPostLayout
            ) : base(cacheHelper)
        {
            repositoryPostLayout = _repositoryPostLayout;
            _logger = logger;

            // upload file, anh : chua xu lo
            //_env = env;
            //_dir = _env.ContentRootPath + "\\wwwroot\\files\\upload\\common\\";
        }
        [HttpGet]
       [Route("api/list")]
       public async Task<IActionResult> List()
        {
            try
            {
                var list = await repositoryPostLayout.List();
                if (list == null || list.Count == 0)
                {
                    return NotFound();
                }
                var response = JsonSerializer.Serialize(list.Cast<object>().ToList());
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
       
    }
}
