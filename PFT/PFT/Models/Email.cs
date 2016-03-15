﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFT.Models
{
    public class Email
    {
        public string EmailID { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        
        public virtual User User { get; set; }
        public virtual Item Item { get; set; }
    }
}