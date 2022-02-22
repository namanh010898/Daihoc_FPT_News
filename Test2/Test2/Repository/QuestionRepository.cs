using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;

namespace Daihoc_FPT_News.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        DaihocFPTNewsContext db;
        public QuestionRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }
        public async Task<List<Question>> GetList_Question()
        {
            if (db != null)
            {
                return await (
                    from quest in db.Questions
                    where (quest.Active == 1 && quest.QuestionTypeId ==1)
                    orderby quest.Id ascending
                    select quest
                    ).ToListAsync();
            }
            return null;
        }
        public async Task<List<Question>> Search_Quest(string key)
        {
            if (db != null)
            {
                return await (
                    from quest in db.Questions
                    where (quest.Active == 1 && (quest.Name.Contains(key) || quest.Text.Contains(key)))
                    orderby quest.Id ascending
                    select quest
                ).ToListAsync();
            }

            return null;
        }

        public async Task<Question> Add_Quest(Question ques)
        {
            if(db != null)
            {
                await db.Questions.AddAsync(ques);
                await db.SaveChangesAsync();
                return ques;
            }
            return null;
        }

        public async Task Delete_Quest(Question ques)
        {
            if (db != null)
            {
                db.Questions.Attach(ques);
                db.Entry(ques).Property(x => x.Active).IsModified = true;

                await db.SaveChangesAsync();
            }
        }

        public async Task Update_Quest(Question ques)
        {
            if(db != null)
            {
                db.Questions.Attach(ques);
                db.Entry(ques).Property(x => x.QuestionTypeId).IsModified = true;
                db.Entry(ques).Property(x => x.Active).IsModified = true;
                db.Entry(ques).Property(x => x.Photo).IsModified = true;
                db.Entry(ques).Property(x => x.Score).IsModified = true;
                db.Entry(ques).Property(x => x.Name).IsModified = true;
                db.Entry(ques).Property(x => x.Description).IsModified = true;
                db.Entry(ques).Property(x => x.Text).IsModified = true;

                await db.SaveChangesAsync();
            }
        }
    }
}
