using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class NewRepository : INewRepository
    {
        DaihocFPTNewsContext db;
        public NewRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }
        public async Task<List<Post>> List()
        {
            return await db.Posts.ToListAsync();
        }
    }
}
