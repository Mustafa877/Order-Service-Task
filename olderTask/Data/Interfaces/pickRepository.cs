
using olderTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace olderTask.Data.Interfaces
{
    public interface pickRepository
    {
        public IEnumerable<OLDERS> OLDERs { get; }

        public  OLDERS GetolderById(int OLDERSId);
       
    }
}
