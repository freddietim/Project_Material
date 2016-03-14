using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FPFT.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FPFT.DAL
{
    public class FLFContext : DbContext
    {
        public FLFContext() : base("FLFContext")
        {
        }
         
        public DbSet<User> Users { get; set; }
        public DbSet<Email> EmailAdd { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}