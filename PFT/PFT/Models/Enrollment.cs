﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace PFT.Models
{
    public class Enrollment
    {
        public DateTime EnrollmentDate { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        
        public virtual User User { get; set; }
        public virtual Item Item { get; set; }
    }
}