using Daihoc_FPT_News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public interface IPostCategoryRepository
    {
        Task<List<PostCategory>> List();
    }
}
