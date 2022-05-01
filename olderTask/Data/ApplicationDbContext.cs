using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using olderTask.Models;
using olderTask.Models.ControlUesrs;
using System;
using System.Collections.Generic;
using System.Text;

namespace olderTask.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public object ShoppingCartItem { get; internal set; }
        public object ShoppingCartItems { get; internal set; }

       
    }
}
