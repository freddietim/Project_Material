using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project_FTF.Models;

namespace Project_FTF.DAL
{
    public class LFInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LFContext>
    {
        protected override void Seed(LFContext context)
        {       
            var items = new List<Item>
            {
                new Item{Status = "Lost", FirstName = "Freddie", LastName = "Timmins", EmailAddress = "freddie@hotmail.com", ItemType = "Phone", ItemDesc="Black iPhone"},
                new Item{Status = "Found", FirstName = "Colm", LastName = "Quish", EmailAddress = "colm@hotmail.com", ItemType = "Wallet", ItemDesc="Brown leather wallet"},
                new Item{Status = "Found", FirstName = "JD", LastName = "Kiely", EmailAddress = "jd@hotmail.com", ItemType = "Keys", ItemDesc="Volkswagon car keys"},
                new Item{Status = "Lost", FirstName = "Ulrich", LastName = "Lunde", EmailAddress = "ulrich@hotmail.com", ItemType = "Jewellery", ItemDesc="Silver tennis bracelet"},            
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();    
                
        }
    }
}