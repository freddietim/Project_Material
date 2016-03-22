using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dbpft.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace dbpft.DAL
{
    public class ItemContext : DbContext
    {
        public ItemContext()
            : base("ItemContext")
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}