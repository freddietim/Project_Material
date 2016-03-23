namespace Project_FTF.Migrations
{
    using Project_FTF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project_FTF.DAL.LFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Project_FTF.DAL.LFContext";
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
}
