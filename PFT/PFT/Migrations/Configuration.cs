namespace PFT.Migrations
{
    using PFT.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<PFT.DAL.LFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "PFT.DAL.LFContext";
        }

        protected override void Seed(PFT.DAL.LFContext context)
        {
            var users = new List<User>
            {
                new User { FirstName = "Freddie",   LastName = "Timmins", 
                    EmailAddress = "freddie_timmins@hotmail.com" },
                new User { FirstName = "Colm", LastName = "Quish",    
                    EmailAddress = "squishdquish@gmail.com" },
                new User { FirstName = "JD",   LastName = "Kiely",     
                    EmailAddress = "jd2dk@hotmail.com" },
                new User { FirstName = "Ulrich",    LastName = "Lunde", 
                    EmailAddress = "ullylully@gmail.com" },
                new User { FirstName = "Jen",      LastName = "Bain",        
                    EmailAddress = "theBain@yahoo.co.uk" },
            
            };
            users.ForEach(s => context.Users.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var items = new List<Item>
            {
                new Item {ItemID = 1050, ItemType = "Phone",      ItemDesc = "Black iPhone 4s", },
                new Item {ItemID = 4022, ItemType = "Wallet", ItemDesc = "Brown leather wallet", },
                new Item {ItemID = 4041, ItemType = "Clothing", ItemDesc = "Red jumper", },
                new Item {ItemID = 1045, ItemType = "Jewellery",       ItemDesc = "silver tennis bracelet", },
                new Item {ItemID = 3141, ItemType = "Car Keys",   ItemDesc = "nissan car keys", },
            
            };
            items.ForEach(s => context.Items.AddOrUpdate(p => p.ItemType, s));
            context.SaveChanges();

            var emailadd = new List<Email>
            {
                new Email { 
                    UserID = users.Single(s => s.LastName == "Timmins").ID, 
                    ItemID = items.Single(c => c.ItemType == "Phone" ).ItemID, 
                    
                },
                 new Email { 
                    UserID = users.Single(s => s.LastName == "Quish").ID,
                    ItemID = items.Single(c => c.ItemType == "Wallet" ).ItemID, 
                    
                 },                            
                 new Email { 
                    UserID = users.Single(s => s.LastName == "Kiely").ID,
                    ItemID = items.Single(c => c.ItemType == "Clothing" ).ItemID, 
                    
                 },
                 new Email { 
                     UserID = users.Single(s => s.LastName == "Lunde").ID,
                    ItemID = items.Single(c => c.ItemType == "Jewellery" ).ItemID, 
                     
                 },
                 new Email { 
                     UserID = users.Single(s => s.LastName == "Bain").ID,
                    ItemID = items.Single(c => c.ItemType == "Car Keys" ).ItemID, 
                   
                 },
                
            };

            foreach (Email e in emailadd)
            {
                var emailInDataBase = context.EmailAdd.Where(
                    s => 
                        s.User.ID == e.UserID &&
                         s.Item.ItemID == e.Item.ItemID).SingleOrDefault();
                if (emailInDataBase == null)
                {
                    context.EmailAdd.Add(e);
                }
            }
            context.SaveChanges();
        }
     }
 }

