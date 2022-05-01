using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using olderTask.Data.Interfaces;
using olderTask.Models;

namespace DrinkAndGo.Data.Repositories
{
    public class IpickRepository : pickRepository
    {
        private readonly DBCOUNT _appDbContext;
        public IpickRepository(DBCOUNT appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<OLDERS> OLDERs => _appDbContext.Olders.Include(c => c);
        public OLDERS GetolderById(int OLDERSId) => _appDbContext.Olders.FirstOrDefault(p => p.id == OLDERSId);
    }
}