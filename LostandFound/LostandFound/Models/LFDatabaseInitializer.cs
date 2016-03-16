using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LostandFound.Models
{
    public class LFDatabaseInitializer : DropCreateDatabaseIfModelChanges<LFContext>
    {
        protected override void Seed(LFContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetItems().ForEach(p => context.Items.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Phones"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Wallets"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Bags"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Keys"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Jewellery"
                },
            };

            return categories;
        }

        private static List<Item> GetItems()
        {
            var items = new List<Item> {
                new Item
                {
                    ItemID = 1,
                    ItemName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + 
                                  "Power it up and let it go!", 
                    ImagePath="carconvert.png",                    
                    CategoryID = 1
               },
                new Item 
                {
                    ItemID = 2,
                    ItemName = "Old-time Car",
                    Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath="carearly.png",                    
                     CategoryID = 1
               },
                new Item
                {
                    ItemID = 3,
                    ItemName = "Fast Car",
                    Description = "Yes this car is fast, but it also floats in water.",
                    ImagePath="carfast.png",                    
                    CategoryID = 1
                },
                new Item
                {
                    ItemID = 4,
                    ItemName = "Super Fast Car",
                    Description = "Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath="carfaster.png",                    
                    CategoryID = 1
                },
                new Item
                {
                    ItemID = 5,
                    ItemName = "Old Style Racer",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." + 
                                  "No batteries required.",
                    ImagePath="carracer.png",
                    
                    CategoryID = 1
                },
                
            };

            return items;
        }
    }
}