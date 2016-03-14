namespace PFT.Migrations
{
    using PFT.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<PFT.DAL.LFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PFT.DAL.LFContext";
        }

        protected override void Seed(PFT.DAL.LFContext context)
        {
            var students = new List<User>
            {
                new User { FirstName = "Carson",   LastName = "Alexander", 
                    EnrollmentDate = DateTime.Parse("2010-09-01") },
                new User { FirstName = "Meredith", LastName = "Alonso",    
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new User { FirstName = "Arturo",   LastName = "Anand",     
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new User { FirstName = "Gytis",    LastName = "Barzdukas", 
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new User { FirstName = "Yan",      LastName = "Li",        
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new User { FirstName = "Peggy",    LastName = "Justice",   
                    EnrollmentDate = DateTime.Parse("2011-09-01") },
                new User { FirstName = "Laura",    LastName = "Norman",    
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new User { FirstName = "Nino",     LastName = "Olivetto",  
                    EnrollmentDate = DateTime.Parse("2005-08-11") }
            };
            students.ForEach(s => context.Users.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var courses = new List<Item>
            {
                new Item {ItemID = 1050, Title = "Chemistry",      Description = "phone", },
                new Item {ItemID = 4022, Title = "Microeconomics", Description = "Bag", },
                new Item {ItemID = 4041, Title = "Macroeconomics", Description = "Purse", },
                new Item {ItemID = 1045, Title = "Calculus",       Description = "Ring", },
                new Item {ItemID = 3141, Title = "Trigonometry",   Description = "Scarf", },
                new Item {ItemID = 2021, Title = "Composition",    Description = "Car Keys", },
                new Item {ItemID = 2042, Title = "Literature",     Description = "Study Notes", }
            };
            courses.ForEach(s => context.Items.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Alexander").ID, 
                    ItemID = courses.Single(c => c.Title == "Chemistry" ).ItemID, 
                     
                },
                 new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Alexander").ID,
                    ItemID = courses.Single(c => c.Title == "Microeconomics" ).ItemID, 
                   
                 },                            
                 new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Alexander").ID,
                    ItemID = courses.Single(c => c.Title == "Macroeconomics" ).ItemID, 
                    
                 },
                 new Enrollment { 
                     UserID = students.Single(s => s.LastName == "Alonso").ID,
                    ItemID = courses.Single(c => c.Title == "Calculus" ).ItemID, 
               
                 },
                 new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Alonso").ID,
                    ItemID = courses.Single(c => c.Title == "Trigonometry" ).ItemID, 
                    
                 },
                 new Enrollment {
                   UserID = students.Single(s => s.LastName == "Alonso").ID,
                   ItemID = courses.Single(c => c.Title == "Composition" ).ItemID, 
                   
                 },
                 new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Anand").ID,
                    ItemID = courses.Single(c => c.Title == "Chemistry" ).ItemID
                 },
                 new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Anand").ID,
                    ItemID = courses.Single(c => c.Title == "Microeconomics").ItemID,
                            
                 },
                new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Barzdukas").ID,
                    ItemID = courses.Single(c => c.Title == "Chemistry").ItemID,
                            
                 },
                 new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Li").ID,
                    ItemID = courses.Single(c => c.Title == "Composition").ItemID,
                            
                 },
                 new Enrollment { 
                    UserID = students.Single(s => s.LastName == "Justice").ID,
                    ItemID = courses.Single(c => c.Title == "Literature").ItemID,
                            
                 }
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s => s.User.ID == e.UserID &&
                         s.Item.ItemID == e.Item.ItemID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();
        }
        }
    }

