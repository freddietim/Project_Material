using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project_FTF.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Project_FTF.DAL
{
    public class LFContext : DbContext
    {
        public LFContext() : base("LFContext")
        {
        }
        
        public DbSet<Item> Items { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Project_FTF.Models.User> Users { get; set; }
    }
}