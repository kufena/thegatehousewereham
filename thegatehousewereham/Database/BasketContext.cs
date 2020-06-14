using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public class BasketContext : DbContext
    {
        public BasketContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Basket> Baskets { get; set; }
        
        public DbSet<BasketPots> BasketPots { get; set; }
    }
}
