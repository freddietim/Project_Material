using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dbpft.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}