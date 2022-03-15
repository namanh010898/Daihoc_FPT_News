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
    public class PostTypeController : BaseController
    {

        private readonly ILogger<HomeController> _logger;
        IPostTypeRepository repositoryPostType;
        public PostTypeController(ILogger<HomeController> logger,
        ICacheHelper cacheHelper,
        IPostTypeRepository _repositoryPostType
        ) : base(cacheHelper)
        {
            repositoryPostType = _repositoryPostType;
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
                var list = await repositoryPostType.List();
                if(list.Count == 0 || list == null)
                {
                    return NotFound();
                }
                var response = JsonSerializer.Serialize(list.Cast<object>().ToList());
                return Ok(response);
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }

    }
}
