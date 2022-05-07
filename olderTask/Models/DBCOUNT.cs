
using Microsoft.EntityFrameworkCore;
//using olderTask.Areas.Identity.Pages.Account;
using olderTask.Models.ControlUesrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace olderTask.Models
{
    public class DBCOUNT : DbContext
    {
        public DBCOUNT(DbContextOptions<DBCOUNT> options)
            : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<all> allUseers { get; set; }
        public DbSet<approved> Approveds { get; set; }
        public DbSet<rejected> Rejecteds { get; set; }
        public DbSet<finish> Finishes { get; set; }
        public DbSet<painds> Painds { get; set; }
       
    }
}
