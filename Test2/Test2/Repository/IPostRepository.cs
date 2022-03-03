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
        Task<List<Post>> Detail(int id);

        Task Delete(Post post);
        Task Update(Post post);
    }
}
