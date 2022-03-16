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

        public async Task<PostCategory> Add(PostCategory postCategory)
        {
            if (db != null)
            {
                await db.PostCategories.AddAsync(postCategory);
                await db.SaveChangesAsync();
                return postCategory;
            }
            return null;
        }

        public async Task Delete(PostCategory postCategory)
        {
            if (db != null)
            {
                db.PostCategories.Attach(postCategory);
                db.Entry(postCategory).Property(x => x.Active).IsModified = true;
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<PostCategory>> Detail(int id)
        {
            if (db != null)
            {
                return await db.PostCategories.Where(x => x.Id == id && x.Active == 1).ToListAsync();
            }
            return null;
        }

        public async Task<List<PostCategory>> List()
        {
            if (db != null)
            {
                return await db.PostCategories.Where(p => p.Active == 1).ToListAsync();
            }
            return null;
        }

        public async Task Update(PostCategory obj)
        {
            if (db != null)
            {
                //Update that object
                db.PostCategories.Attach(obj);
                db.Entry(obj).Property(x => x.Active).IsModified = true;
                db.Entry(obj).Property(x => x.Name).IsModified = true;
                db.Entry(obj).Property(x => x.Slug).IsModified = true;
                db.Entry(obj).Property(x => x.Description).IsModified = true;
                db.Entry(obj).Property(x => x.Photo).IsModified = true;
                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
    }
}
