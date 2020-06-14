using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public class PotterShopContext : DbContext
    {
        public PotterShopContext(DbContextOptions<PotterShopContext> options) : base(options)
        { }

        public DbSet<Pots> Pots { get; set; }
        public DbSet<PotImages> PotImages { get; set; }
    }
}
