using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PFT.DAL;
using PFT.Models;
using System.Data.Entity.Infrastructure;

namespace PFT.Controllers
{
    public class UserController : Controller
    {
        private LFContext db = new LFContext();

        // GET: User
        public ViewResult Index()
        {
            return View(db.Users.ToList());
        }
      /*  public ActionResult Index(string sortOrder, string searchString)
        {
              ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
              ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
              var users = from s in db.Users
                  select s;
              if (!String.IsNullOrEmpty(searchString))
              {
                  users = users.Where(s => s.LastName.Contains(searchString)
                                         || s.FirstMidName.Contains(searchString));
              }
               switch (sortOrder)
                {
                    case "name_desc":
                     users = users.OrderByDescending(s => s.LastName);
                     break;
                   case "Date":
                      users = users.OrderBy(s => s.EnrollmentDate);
                      break;
                    case "date_desc":
                       users = users.OrderByDescending(s => s.EnrollmentDate);
                       break;
                 default:
                     users = users.OrderBy(s => s.LastName);
                       break;
         }
            return View(db.Users.ToList());
}*/
      
        // GET: User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] User user)
        {
          //   try
            //{
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
               //  catch (RetryLimitExceededException /* dex */)
             /*{
                 //Log the error (uncomment dex variable name and add a line here to write a log.
                 ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }*/

            return View(user);
        }

        // GET: User/Edit/5
    //    [HttpPost, ActionName("Edit")]
      //  [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           // var userToUpdate = db.Users.Find(id);
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
             /*if (TryUpdateModel(userToUpdate, "",
               new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
              {
                  try
                  {
                     db.SaveChanges();

                    return RedirectToAction("Index");
             }
             catch (DataException /* dex *///)
             //{
            //Log the error (uncomment dex variable name and add a line here to write a log.
          //  ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
      //  }
   /*  }
     return View(userToUpdate);
}*/
        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int? id/*, bool? saveChangesError = false*/)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            /*if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }*/
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //try
            //{
                User user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
          //  catch (RetryLimitExceededException /* dex */)
            /*{
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }
       /* [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }*/

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
