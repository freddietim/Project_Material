using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PFT.Models;

namespace PFT.DAL
{
    public class LFInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LFContext>
    {
        protected override void Seed(LFContext context)
        {
            var users = new List<User>
            {
                new User{FirstName="Freddie", LastName="Timmins", EmailAddress="freddie_timmins@hotmail.com"},
                new User{FirstName="Colm", LastName="Quish", EmailAddress="squishDquish@hotmail.com"},
                new User{FirstName="JD", LastName="Kiely", EmailAddress="jd2dk@hotmail.com"},
                new User{FirstName="Ulrich", LastName="Lunde", EmailAddress="ullylully@hotmail.com"},
                new User{FirstName="Jen", LastName="Bain", EmailAddress="theBain@hotmail.com"},
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
            var items = new List<Item>
            {
                new Item{ItemID=1010, UserId= 1, ItemType="Phone", ItemDesc="Black iPhone 4S"},
                new Item{ItemID=1020, UserId= 2, ItemType="Wallet", ItemDesc="Browm leather wallet"},
                new Item{ItemID=1030, UserId= 3,ItemType="Clothing", ItemDesc="Red Fleece"},
                new Item{ItemID=1040,UserId= 4, ItemType="Jewellery", ItemDesc="Silver bracelet"},
                new Item{ItemID=1050,UserId= 5, ItemType="Car Keys", ItemDesc="Nissan car keys"},           
            };

            items.ForEach(i => context.Items.Add(i));
            context.SaveChanges();
            var emailadd = new List<Email>
            {
                new Email{UserID=1, ItemID=1010},
                new Email{UserID=2, ItemID=1020},
                new Email{UserID=3, ItemID=1030},
                new Email{UserID=4, ItemID=1040},
                new Email{UserID=5, ItemID=1050},            
            };
            emailadd.ForEach(e => context.EmailAdd.Add(e));
            context.SaveChanges();
        }
    }
}