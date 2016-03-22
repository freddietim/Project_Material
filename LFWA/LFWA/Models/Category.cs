using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFWA.Models
{
    public class Category
    {
        public int CID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}