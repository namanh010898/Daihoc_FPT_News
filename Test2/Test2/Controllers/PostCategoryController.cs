using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Daihoc_FPT_News.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostCategoryController : BaseController
    {
        IPostCategoryRepository repository;
        IPostRepository repositoryPost;
        public PostCategoryController(
          ICacheHelper cacheHelper,
          IPostCategoryRepository _repository,  IPostRepository _repositoryPost) : base(cacheHelper)
        {
            repository = _repository;
            
            repositoryPost = _repositoryPost;
        }
        [HttpGet]
        [Route("api/list")]
        public async Task<IActionResult> List()
        {
            try
            {
                var datalist = await repository.List();
                if(datalist == null || datalist.Count == 0)
                {
                    return NotFound();
                }
                var response = JsonSerializer.Serialize(datalist.Cast<object>().ToList());
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
