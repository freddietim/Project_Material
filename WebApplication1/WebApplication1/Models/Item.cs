using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dbpft.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public int UserID { get; set; }
        public string ItemType { get; set; }
        public string ItemDesc { get; set; }
        public virtual User User { get; set; }
    }
}