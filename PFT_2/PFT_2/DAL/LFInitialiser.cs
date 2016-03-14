using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PFT_2.Models; 

namespace PFT_2.DAL
{
    public class LFInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<LF_2Context>
    {
        protected override void Seed(LF_2Context context)
        {
            var users = new List<User>
            {
                new User{FirstName="Freddie", LastName="Timmins", EmailAddress="freddie_timmins@hotmail.com"},
                new User{FirstName="Colm", LastName="Quish", EmailAddress="quishDsquish@gmail.com"},
                new User{FirstName="JD", LastName="Kiely", EmailAddress="jd2dk@hotmail.com"},
                new User{FirstName="Ulrich", LastName="Lunde", EmailAddress="ullyLully@gmail.com"},
                new User{FirstName="Jen", LastName="Bain", EmailAddress="theBain@yahoo.co.uk"},
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var items = new List<Item>
            {
                new Item{ItemID= 1010,ItemType="Phone", ItemDesc="Black Iphone 4S"},
                new Item{ItemID= 1020,ItemType="Wallet", ItemDesc="Brown leather wallet"},
                new Item{ItemID= 1030,ItemType="Laptop", ItemDesc="Mac i7"},
                new Item{ItemID= 1040,ItemType="Clothing", ItemDesc="Red ladies jumper"},
                new Item{ItemID= 1050,ItemType="Car Keys", ItemDesc="Nissan car keys"},
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
            var emailadd = new List<Email>
            {
                new Email{UserID=001, ItemID= 1010},
                new Email{UserID=002, ItemID= 1020},
                new Email{UserID=003, ItemID= 1030},
                new Email{UserID=004, ItemID= 1040},
                new Email{UserID=005, ItemID= 1050},
            };

            emailadd.ForEach(s => context.EmailAdd.Add(s));
            context.SaveChanges();
                
        }
    }
}