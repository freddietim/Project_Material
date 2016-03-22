using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB1.Models;
using System.Data.Entity;
using DB1.DAL;

namespace DB1.DAL
{
    public class LFInitializer : DropCreateDatabaseIfModelChanges<LostandFoundDBEntities>
    {
        protected override void Seed(LostandFoundDBEntities context)
        {
            var user = new User
            {
                FirstName = "Freddie",
                LastName = "Timmins",
                EmailAddress = "freddie_timmins@hotmail.com"
            };

            var items = new List<Item>
            {
                new Item {
                    User = user,
                    ItemType = "Phone",
                    ItemDesc = "Black iPhone 5 found in i.t department."
                },
                  new Item {
                    User = user,
                    ItemType = "Wallet",
                    ItemDesc = "Brown leather wallet fround in college bar."
                },
                  new Item {
                    User = user,
                    ItemType = "Bag",
                    ItemDesc = "Red jansport shcool bag found in library."
                },
                  new Item {
                    User = user,
                    ItemType = "Keys",
                    ItemDesc = "Volkswagon car keys found with 2 house keys attached in Quadrangle."
                },
                  new Item {
                    User = user,
                    ItemType = "Jewellery",
                    ItemDesc = "Silver tennis bracelet found in Tower block 1."
                },
            };
            items.ForEach(i => context.Items.Add(i));
            context.SaveChanges();
        }
    }
}