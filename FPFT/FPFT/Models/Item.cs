﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPFT.Models
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }
        public string ItemType { get; set; }
        public string ItemDesc { get; set; }

        public virtual ICollection<Email> EmailAdd { get; set; }
    }
}