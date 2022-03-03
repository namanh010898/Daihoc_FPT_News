using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class PostRepository : IPostRepository
    {
        DaihocFPTNewsContext db;
        public PostRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }

        public async Task Delete(Post post)
        {
            if (db != null)
            {
                db.Posts.Attach(post);
                db.Entry(post).Property(x => x.Active).IsModified = true;
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<Post>> Detail(int id)
        {
            if (db != null)
            {
                return await db.Posts.Where(p => p.Id == id && p.Active == 1).ToListAsync();
            }
            return null;
        }

        public async Task<List<Post>> List()
        {
            if(db != null)
            {
                return await db.Posts.Where(p => p.Active == 1).ToListAsync();
            }
            return null;
        }

        public Task Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
