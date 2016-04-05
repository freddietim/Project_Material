using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project_FTF.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Project_FTF.DAL
{
    public class LFContext :  IdentityDbContext<ApplicationUser>
    {
        public LFContext() : base("LFContext")
        {
        }
        
        public DbSet<Item> Items { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Contact> Contacts { get; set; }

        public static LFContext Create()
        {
            return new LFContext();
        }
    }
   
}