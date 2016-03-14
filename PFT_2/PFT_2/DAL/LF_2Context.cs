using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PFT_2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PFT_2.DAL
{
    public class LF_2Context : DbContext
    {
        public LF_2Context() : base("LF_2Context")
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