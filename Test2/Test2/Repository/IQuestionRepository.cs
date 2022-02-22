using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Daihoc_FPT_News.Models;

namespace Daihoc_FPT_News.Repository
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetList_Question();
    }
}
