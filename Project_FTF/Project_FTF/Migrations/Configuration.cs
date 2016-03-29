namespace Project_FTF.Migrations
{
    using Project_FTF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Project_FTF.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<Project_FTF.DAL.LFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Project_FTF.DAL.LFContext";
        }
        bool AddUserAndRole(Project_FTF.DAL.LFContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                 new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "admin@lostandfound.com",
            };
            ir = um.Create(user, "P_assw0rd1");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(Project_FTF.DAL.LFContext context)
        {
            var items = new List<Item>
            {
                new Item{Status = "Lost", FirstName = "Freddie", LastName = "Timmins", EmailAddress = "freddie@hotmail.com", ItemType = "Phone", ItemDesc="Black iPhone"},
                new Item{Status = "Found", FirstName = "Colm", LastName = "Quish", EmailAddress = "colm@hotmail.com", ItemType = "Wallet", ItemDesc="Brown leather wallet"},
                new Item{Status = "Found", FirstName = "JD", LastName = "Kiely", EmailAddress = "jd@hotmail.com", ItemType = "Keys", ItemDesc="Volkswagon car keys"},
                new Item{Status = "Lost", FirstName = "Ulrich", LastName = "Lunde", EmailAddress = "ulrich@hotmail.com", ItemType = "Jewellery", ItemDesc="Silver tennis bracelet"},            
            };
            items.ForEach(s => context.Items.AddOrUpdate(p => p.EmailAddress, s));
            context.SaveChanges();

            AddUserAndRole(context);
            context.Users.AddOrUpdate(p => p.UserName,
                new User { UserName = "FreddieTim", EmailAddress = "freddie_@hotmail.com" },
                new User { UserName = "ColmQ", EmailAddress = "colm_@hotmail.com" },
                new User { UserName = "JDk", EmailAddress = "jd_@hotmail.com" }
                );                         
            
        }
          

           
                
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }

