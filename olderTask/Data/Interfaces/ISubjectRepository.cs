
using olderTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace olderTask.Data.Interfaces
{
    public interface ISubjectRepository
    {
        public IEnumerable<Subject> subjects { get; }

        public  Subject GetSubjectById(int subjectId);
       
    }
}
