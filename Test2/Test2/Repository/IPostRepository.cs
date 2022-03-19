using Daihoc_FPT_News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public interface IPostRepository
    {
        Task<List<Post>> List();
        Task<List<Post>> ListAllEvent();

        Task<List<Post>> ListEventsIsGoingOnPaging(int pageIndex, int pageSize);

        Task<List<Post>> ListEventsEndedPaging(int pageIndex, int pageSize);
        Task<List<Post>> Detail(int id);
        Task<Post> Add(Post post);
        Task Delete(Post post);
        Task Update(Post post);
        Task<List<Post>> ListSearch(string name);
    }
}
