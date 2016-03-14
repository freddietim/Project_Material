using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PFT.Models;

namespace PFT.DAL
{
    public class LFInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LFContext>
    {
        protected override void Seed(LFContext context)
        {
            var users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new User{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new User{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new User{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new User{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new User{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new User{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new User{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var items = new List<Item>
            {
            new Item{ItemID=1050,Title="Chemistry",Description= "Purse", Location = "IT Department"},
            new Item{ItemID=4022,Title="Microeconomics",Description="Phone",Location = "Smokeys"},
            new Item{ItemID=4041,Title="Macroeconomics",Description="Bag", Location = "Bialann"},
            new Item{ItemID=1045,Title="Calculus",Description="Ring",Location = "College Bar"},
            new Item{ItemID=3141,Title="Trigonometry",Description="Scarf", Location = "Cairnes Buliding, Top Floor"},
            new Item{ItemID=2021,Title="Composition",Description="Car Keys",Location = "Darcy Thompson Theatre, Concourse"},
            new Item{ItemID=2042,Title="Literature",Description="Study Notes",Location = "Library, 1st floor"}
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{UserID=1,ItemID=1050},
            new Enrollment{UserID=1,ItemID=4022},
            new Enrollment{UserID=1,ItemID=4041},
            new Enrollment{UserID=2,ItemID=1045},
            new Enrollment{UserID=2,ItemID=3141},
            new Enrollment{UserID=2,ItemID=2021},
            new Enrollment{UserID=3,ItemID=1050},
            new Enrollment{UserID=4,ItemID=1050},
            new Enrollment{UserID=4,ItemID=4022},
            new Enrollment{UserID=5,ItemID=4041},
            new Enrollment{UserID=6,ItemID=1045},
            new Enrollment{UserID=7,ItemID=3141},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            /*var items = new List<Item>
            {
            new Item{Title="Carson",="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Item{Title="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Item{Title="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Item{Title="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Item{Title="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Item{Title="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Item{Title="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Item{Title="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var items = new List<Item>
            {
            new Item{ItemID=1050,Title="Chemistry",Credits=3,},
            new Item{ItemID=4022,Title="Microeconomics",Credits=3,},
            new Item{ItemID=4041,Title="Macroeconomics",Credits=3,},
            new Item{ItemID=1045,Title="Calculus",Credits=4,},
            new Item{ItemID=3141,Title="Trigonometry",Credits=4,},
            new Item{ItemID=2021,Title="Composition",Credits=3,},
            new Item{ItemID=2042,Title="Literature",Credits=4,}
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{UserID=1,ItemID=1050},
            new Enrollment{UserID=1,ItemID=4022},
            new Enrollment{UserID=1,ItemID=4041},
            new Enrollment{UserID=2,ItemID=1045},
            new Enrollment{UserID=2,ItemID=3141},
            new Enrollment{UserID=2,ItemID=2021},
            new Enrollment{UserID=3,ItemID=1050},
            new Enrollment{UserID=4,ItemID=1050},
            new Enrollment{UserID=4,ItemID=4022},
            new Enrollment{UserID=5,ItemID=4041},
            new Enrollment{UserID=6,ItemID=1045},
            new Enrollment{UserID=7,ItemID=3141},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();*/
        }
    }
}