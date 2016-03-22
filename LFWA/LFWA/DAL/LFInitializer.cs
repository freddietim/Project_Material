using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LFWA.Models;
using System.Data.Entity;

namespace LFWA.DAL
{
    public class LFInitializer : DropCreateDatabaseIfModelChanges<LFContext>
    {
        protected override void Seed(LFContext context)
        {
            var categories = new List<Category>
            {
              new Category {
                    Name = "Phone"
              },
              new Category{
                  Name = "Jewellery"
              },
              new Category {
                  Name = "Keys"
              },
              new Category{
                  Name = "Clothing"
              },
              new Category {
                  Name = "Wallets"
              },
            };
            categories.ForEach(c => context.Categories.Add(c));

            var user = new User
            {
                FirstName = "Colm",
                LastName = "Quish",
                EmailAddress = "squishdquish@hotmail.com"
            };

            var items = new List<Item>
            { 
                new Item {
                    User = user,
                    ItemType = "Phone",
                    ItemDesc = "Black iPhone with pink cover."
                },
                new Item {
                    User = user,
                    ItemType = "Bag",
                    ItemDesc = "Brown leather mens satchel."
                },
                new Item {
                    User = user,
                    ItemType = "Jewellery",
                    ItemDesc ="Silver tennis bracelet."
                },
                new Item {
                    User = user,
                    ItemType = "Keys",
                    ItemDesc = "Nissan Micra car keys with 2 house keys on keyring."
                }
            };
            items.ForEach(i => context.Items.Add(i));
            context.SaveChanges(); 
                        
        }
    }
}