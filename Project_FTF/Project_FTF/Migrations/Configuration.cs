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
            AutomaticMigrationsEnabled = false;
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
                UserName = "admins@lostandfound.com",
            };
            ir = um.Create(user, "Admins1!");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
            
        }

        protected override void Seed(Project_FTF.DAL.LFContext context)
        {
            AddUserAndRole(context);
            var items = new List<Item>
            {
                new Item{Status = "Lost", FirstName = "Freddie", LastName = "Timmins", EmailAddress = "freddie@hotmail.com", ItemType = "Phone", ItemDesc="Black iPhone", Location = "College Bar, NUI Galway, Newcastle, Galway"},
                new Item{Status = "Found", FirstName = "Colm", LastName = "Quish", EmailAddress = "colm@hotmail.com", ItemType = "Wallet", ItemDesc="Brown leather wallet", Location = "IT 312, IT Department, NUI Galway, Newcastle, Galway"},
                new Item{Status = "Found", FirstName = "JD", LastName = "Kiely", EmailAddress = "jd@hotmail.com", ItemType = "Keys", ItemDesc="Volkswagon car keys", Location = "Kingfisher Gym, NUI Galway, Newcastle, Galway"},
                new Item{Status = "Lost", FirstName = "Ulrich", LastName = "Lunde", EmailAddress = "ulrich@hotmail.com", ItemType = "Jewellery", ItemDesc="Silver tennis bracelet", Location = "Smokeys, NUI Galway, Newcastle, Galway"}, 
                new Item{Status = "Lost", FirstName = "Patrick", LastName = "Glynn", EmailAddress = "patrick@hotmail.com", ItemType = "Phone", ItemDesc="Samsung Galaxy s6, screen saver of my dog lilo.", Location = "College Bar, NUI Galway, Newcastle, Galway"},
                new Item{Status = "Found", FirstName = "John", LastName = "Hanbury", EmailAddress = "john@hotmail.com", ItemType = "Sports Equipment", ItemDesc="Large white cooper helment, lost on wednesday 13.4.16", Location = "Dangan Sports Grounds, Dangan, Galway"},
                new Item{Status = "Found", FirstName = "Caoimhe", LastName = "", EmailAddress = "caoimhe@hotmail.com", ItemType = "Wallet", ItemDesc="Brown Michael Kors wallet, identification inside", Location = "College Bar, NUI Galway, Newcastle, Galway"},
                new Item{Status = "Lost", FirstName = "Tara", LastName = "Grealish", EmailAddress = "tara@hotmail.com", ItemType = "Sports Equipment", ItemDesc="Nike roshe runs, ladies, size 5", Location = "Kingfisher Gym, NUI Galway, Newcastle, Galway"},
                new Item{Status = "Lost", FirstName = "Mark", LastName = "O'Rourke", EmailAddress = "mark@hotmail.com", ItemType = "Sports Equipment", ItemDesc="Squash racket with my name engraved on it and the date 16.3.93", Location = "Kingfisher Gym, NUI Galway, Newcastle, Galway"},
            
            };

            items.ForEach(s => context.Items.AddOrUpdate(p => p.EmailAddress, s));
            context.SaveChanges();
                       
            context.Contacts.AddOrUpdate(u => u.UserName,
                new Contact { UserName = "FreddieTim", EmailAddress = "freddie_@hotmail.com" },
                new Contact { UserName = "ColmQ", EmailAddress = "colm_@hotmail.com" },
                new Contact { UserName = "JDk", EmailAddress = "jd_@hotmail.com" },
                new Contact { UserName = "Ulrich", EmailAddress = "ulirch@hotmail.com" },
                new Contact { UserName = "Pajo", EmailAddress = "patrick@hotmail.com" },
                new Contact { UserName = "Johnboi", EmailAddress = "john@hotmail.com" },
                new Contact { UserName = "Caoimhs", EmailAddress = "caoimhe@hotmail.com" },
                new Contact { UserName = "Tazz", EmailAddress = "tara@hotmail.com" },
                new Contact { UserName = "Marky", EmailAddress = "mark@hotmail.com" }
                );
            
            
        }                
      }
    }

