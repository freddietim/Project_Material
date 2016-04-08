using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace Project_FTF.Models
{
    [Bind(Exclude = "ID")]
    public class Item
    {
       // [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required]        
        public string Status { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "An email address is required")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please enter what type of item it is")]
        public string ItemType { get; set; }
        [Required(ErrorMessage = "Please provide a short description of the item")]
        [StringLength(1024)]
        public string ItemDesc { get; set; }
        [Required(ErrorMessage = "Please specify a location")]
        public string Location { get; set; }

        public string Abstract { get; set; }
       
    }
}