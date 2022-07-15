using System;
using Microsoft.EntityFrameworkCore;

namespace HerbalApothecary.Models
{
    public class HerbContext : DbContext
    {
        public HerbContext(DbContextOptions<HerbContext> options) : base(options) { }

        public DbSet<Herb> Herbs { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<InventoryItem> Items { get; set; }
    }
}

