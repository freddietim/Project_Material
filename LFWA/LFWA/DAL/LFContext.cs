using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LFWA.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LFWA.DAL
{
    public class LFContext : DbContext
    {
      //  public LFContext() : base("LFContext")
        //{
        //}
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}