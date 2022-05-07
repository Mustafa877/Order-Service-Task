using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using olderTask.Data.Interfaces;
using olderTask.Models;

namespace DrinkAndGo.Data.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly DBCOUNT _appDbContext;
        public SubjectRepository(DBCOUNT appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Subject> subjects => _appDbContext.Subjects.Include(c => c);
        public Subject GetSubjectById(int subjectId) => _appDbContext.Subjects.FirstOrDefault(p => p.Subjectid == subjectId);
    }
}