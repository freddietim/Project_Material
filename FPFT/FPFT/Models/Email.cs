using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FPFT.Models
{
    public class Email
    {
        public int EmailID { get; set; }
        public int ItemID { get; set; }
        public int UserID { get; set; }

        public virtual Item Item { get; set; }
        public virtual User User { get; set; }
    }
}