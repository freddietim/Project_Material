namespace Project_FTF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedUsertoContact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            DropTable("dbo.User");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            DropTable("dbo.Contact");
        }
    }
}
