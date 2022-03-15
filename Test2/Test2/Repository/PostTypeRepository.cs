using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class PostTypeRepository : IPostTypeRepository
    {
        DaihocFPTNewsContext db;
        public PostTypeRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }
        public async Task<List<PostType>> List()
        {
            return await db.PostTypes.Where(x => x.Active == 1).ToListAsync();
        }
    }
}
