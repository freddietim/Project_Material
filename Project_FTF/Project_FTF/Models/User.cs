using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.AspNet.Identity;

namespace Project_FTF.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}