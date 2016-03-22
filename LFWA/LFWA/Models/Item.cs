using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFWA.Models
{
    public class Item
    {
        public int ItemID { get; set; }
      //  public int UserID { get; set; }
       // public int CategoryID { get; set; }
        public string ItemType { get; set; }
        public string ItemDesc { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}