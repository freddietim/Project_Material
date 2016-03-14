using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using project_FT.Models;

namespace project_FT.DataAccessLayer
{
    public class LFInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<LFContextft>
    {
        protected override void Seed(LFContextft context)
        {
            var users = new List<User>
            {
                new User{FirstName="Freddie", LastName="Timmins", EmailAddress="ft@hotmail.com"},
                new User{FirstName="Colm", LastName="Quish", EmailAddress="cq@hotmail.com"},
                new User{FirstName="JD", LastName="Kiely", EmailAddress="jdk@hotmail.com"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var items = new List<Item>
            {
                new Item{ItemID=001, ItemType="Phone", ItemDesc="Black IPhone"},
                new Item{ItemID=002, ItemType="Wallet", ItemDesc="Brown leather wallet"},
                new Item{ItemID=003, ItemType="Car Keys",ItemDesc="Nissan Keys"}
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();              
        }
    }
}