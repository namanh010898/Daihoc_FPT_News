using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class PostCategoryRepository : IPostCategoryRepository
    {
        DaihocFPTNewsContext db;
        public PostCategoryRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }
        public async Task<List<PostCategory>> List()
        {
            return await db.PostCategories.Where(p => p.Active == 1).ToListAsync();
        }
    }
}
