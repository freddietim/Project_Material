using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LostandFound.Models
{
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ItemID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ItemName { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
       // public DateTime date_submitted { get; set; }

        public string ImagePath { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}