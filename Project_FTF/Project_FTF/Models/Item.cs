using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_FTF.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ItemType { get; set; }
        public string ItemDesc { get; set; }

       
    }
}