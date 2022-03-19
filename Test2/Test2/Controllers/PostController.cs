using Daihoc_FPT_News.Models;
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
    public class PostController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        IPostRepository repositoryPost;

        public PostController(ILogger<HomeController> logger,
            ICacheHelper cacheHelper,
            IPostRepository _repositoryPost
            ) : base(cacheHelper)
        {
            repositoryPost = _repositoryPost;
            _logger = logger;

            // upload file, anh : chua xu lo
            //_env = env;
            //_dir = _env.ContentRootPath + "\\wwwroot\\files\\upload\\common\\";
        }
        [HttpGet]
        [Route("admin/list")]
        public async Task<IActionResult> AdminList()
        {
            var listPost = await repositoryPost.List();
            ViewBag.Posts = listPost;
            ViewBag.PostCount = listPost.Count;
            return View();
        }

        [HttpGet]
        [Route("admin/listEvents")]
        public async Task<IActionResult> AdminListEvents()
        {
            var listPost = await repositoryPost.List();
            ViewBag.Posts = listPost;
            ViewBag.PostCount = listPost.Count;
            return View();
        }

        [HttpGet]
        [Route("add/post")]
        public async Task<IActionResult> AddPost()
        {
            //var listPost = await repositoryPost.List();
            //ViewBag.Posts = listPost;
            //ViewBag.PostCount = listPost.Count;
            return View();
        }
        [HttpGet]
        [Route("api/detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            try
            {
                var Item = await repositoryPost.Detail(id);
                if (Item == null || Item.Count == 0)
                {
                    return NotFound();
                }
                var response = JsonSerializer.Serialize(Item.Cast<object>().ToList());
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("api/delete")]
        public async Task<IActionResult> Delete([FromBody] Post model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Active = 0;
                    await repositoryPost.Delete(model);
                    return Ok();
                }
                catch(Exception e)
                {
                    if(e.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("api/Add")]
        public async Task<IActionResult> Add([FromBody]Post model)
        {
            if (ModelState.IsValid)
            {
                model.Active = 1;
                model.CreatedTime = DateTime.Now;
                if (model.CommentCount == null) model.CommentCount = 0;
                if (model.ViewCount == null) model.ViewCount = 0;
                if (model.LikeCount == null) model.LikeCount = 0;
                try
                {
                    var newObj = await repositoryPost.Add(model);
                    newObj.Url = NovaticUtil.ConvertToURL(newObj.Id + "-" + newObj.Name);
                    await repositoryPost.Update(newObj);
                    return Created("", newObj);
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("api/edit")]
        public async Task<IActionResult> Edit([FromBody] Post model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await repositoryPost.Update(model);
                    return Created("", model);
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("api/search/{name}")]
        public async Task<IActionResult> Search(string name)
        {
            try
            {
                var list = await repositoryPost.ListSearch(name);
                if(list.Count == 0 || list == null)
                {
                    return NotFound();
                }
                var response = JsonSerializer.Serialize(list.Cast<object>().ToList());
                return Ok(response);
            }catch(Exception e)
            {
                return BadRequest();
            } 
        }
    }
}
