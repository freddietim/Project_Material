using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LostandFound.Models
{
    public class LFContext : DbContext
    {
        public LFContext()
            : base("LostandFound")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}