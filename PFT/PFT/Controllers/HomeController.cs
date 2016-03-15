﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PFT.DAL;
using PFT.Models;

namespace PFT.Controllers
{
    public class HomeController : Controller
    {
       // private LFContext db = new LFContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What this application is all about!";
                      
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
         /* public ActionResult Form()
        {
            ViewBag.Message = "Please post here";

            return View();
        }
          protected override void Dispose(bool disposing)
          {
              db.Dispose();
              base.Dispose(disposing);
          }*/
    }
}