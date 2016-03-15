using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PFT.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PFT.DAL
{
    public class LFContext : DbContext{

        public LFContext() : base("LFContext")
        {
        }
        public DbSet<User> Users {get; set; }
        public DbSet<Email> EmailAdd {get; set; }
        public DbSet<Item> Items { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    
    }
