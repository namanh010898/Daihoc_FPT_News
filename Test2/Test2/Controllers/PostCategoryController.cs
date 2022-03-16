using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Daihoc_FPT_News.Models;

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
        [Route("admin/list")]
        public async Task<IActionResult> AdminList()
        {
            var listcate = await repository.List();
            ViewBag.listcate = listcate;
            ViewBag.catecount = listcate.Count();
            return View();
        }

        [HttpGet]
        [Route("add/postcategory")]
        public async Task<IActionResult> AddPostCategory()
        {
            return View();
        }
        [HttpPost]
        [Route("api/add")]
        public async Task<IActionResult> Add([FromBody]PostCategory model)
        {
            if (ModelState.IsValid)
            {
                model.Active = 1;
                model.CreatedTime = DateTime.Now;
                model.ParentId = 0;
                model.PostCount = 0;
                try
                {
                    var newObj = await repository.Add(model);
                    var message = "success";
                    newObj.Slug = NovaticUtil.ConvertToURL(newObj.Id + "-" + newObj.Name);
                    await repository.Update(newObj);
                    return Created("", message);
                }catch(Exception e)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
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

        [HttpGet]
        [Route("api/detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            try
            {
                var item = await repository.Detail(id);
                if(item == null || item.Count == 0)
                {
                    return NotFound();
                }
                var response = JsonSerializer.Serialize(item.Cast<object>().ToList());
                return Ok(response);
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("api/delete")]
        public async Task<IActionResult> Delete([FromBody] PostCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Active = 0;
                    await repository.Delete(model);
                    return Ok(model);
                }
                catch (Exception e)
                {
                    if (e.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("api/edit")]
        public async Task<IActionResult> Edit([FromBody]PostCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await repository.Update(model);
                    return Created("", model);
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }
    }
}
