using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Project_FTF.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {       
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {          
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

   /*public class LFContext : IdentityDbContext<ApplicationUser>
    {
       public LFContext()
           : base("LFContext", throwIfV1Schema: false)
        {
        }
       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
                .ToTable("User");
            modelBuilder.Entity<ApplicationUser>()
                .ToTable("User");
        
        }
        public DbSet<Item> Items { get; set; }
        public System.Data.Entity.DbSet<Project_FTF.Models.User> Users { get; set; }

        public static LFContext Create()
        {
            return new LFContext();
        }
    }*/
}