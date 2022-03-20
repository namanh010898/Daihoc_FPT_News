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

        public async Task<Post> Add(Post post)
        {
            if (db != null)
            {
                await db.Posts.AddAsync(post);
                await db.SaveChangesAsync();
                return post;
            }
            return null;
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

        public async Task<List<Post>> ListEvent()
        {
            if (db != null)
            {
                return await db.Posts.Where(p => p.PostCategoryId == 3 && p.Active == 1).ToListAsync();
            }
            return null;
        }

        public async Task<List<Post>> ListGeneral()
        {
            if (db != null)
            {
                return await db.Posts.Where(p => p.PostCategoryId == 1 && p.Active == 1).ToListAsync();
            }
            return null;
        }


        // List tất cả các sự kiện sắp xếp từ mới đến cũ
        public async Task<List<Post>> ListAllEvent()
        {
            if (db != null)
            {
                return await db.Posts.Where(p => p.Active == 1 && p.PostCategoryId == 3).ToListAsync();
            }
            return null;
        }

        //List Paging Event dang dien ra
        public async Task<List<Post>> ListEventsIsGoingOnPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                return await db.Posts.Where(p => p.Active == 1 && p.PostCategoryId == 3 &&  p.OpenTime < DateTime.Now && p.ClosedTime > DateTime.Now).Skip(offSet).Take(pageSize).ToListAsync(); ;
            } 
            return null;

        }

        //List Paging Event dang dien ra
        public async Task<List<Post>> ListEventsEndedPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                return await db.Posts.Where(p => p.Active == 1 && p.PostCategoryId == 3 &&  p.ClosedTime < DateTime.Now).Skip(offSet).Take(pageSize).ToListAsync(); ;
            } 
            return null;

        }

        public async Task<List<Post>> ListSearch(string name)
        {
            if (db != null)
            {
                return await db.Posts.Where(x => x.Name.Contains(name) && x.Active == 1).ToListAsync();
            }
            return null;
        }

        public async Task Update(Post obj)
        {
            if(db != null)
            {
                db.Posts.Attach(obj);
                db.Entry(obj).Property(x => x.PostTypeId).IsModified = true;
                db.Entry(obj).Property(x => x.PostAccountId).IsModified = true;
                db.Entry(obj).Property(x => x.PostCategoryId).IsModified = true;
                db.Entry(obj).Property(x => x.PostLayoutId).IsModified = true;
                db.Entry(obj).Property(x => x.PostPublishStatusId).IsModified = true;
                db.Entry(obj).Property(x => x.PostCommentStatusId).IsModified = true;
                db.Entry(obj).Property(x => x.Photo).IsModified = true;
                db.Entry(obj).Property(x => x.Video).IsModified = true;
                db.Entry(obj).Property(x => x.ViewCount).IsModified = true;
                db.Entry(obj).Property(x => x.CommentCount).IsModified = true;
                db.Entry(obj).Property(x => x.LikeCount).IsModified = true;
                db.Entry(obj).Property(x => x.Active).IsModified = true;
                db.Entry(obj).Property(x => x.Url).IsModified = true;
                db.Entry(obj).Property(x => x.Name).IsModified = true;
                db.Entry(obj).Property(x => x.Description).IsModified = true;
                db.Entry(obj).Property(x => x.Text).IsModified = true;
                db.Entry(obj).Property(x => x.OpenTime).IsModified = true;
                db.Entry(obj).Property(x => x.ClosedTime).IsModified = true;
                db.Entry(obj).Property(x => x.EventAddress).IsModified = true;
                db.Entry(obj).Property(x => x.FileUrl).IsModified = true;
                //db.Entry(obj).Property(x => x.PublishedTime).IsModified = true;
                //db.Entry(obj).Property(x => x.CreatedTime).IsModified = true;

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
    }
}
