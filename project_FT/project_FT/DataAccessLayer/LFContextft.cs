using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using project_FT.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace project_FT.DataAccessLayer
{
    public class LFContextft : DbContext
    {

        public LFContextft()
            : base("Data Source=(LocalDB)\v11.0;Initial Catalog=PFTDb2;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}