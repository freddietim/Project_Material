namespace PFT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Email",
                c => new
                    {
                        EmailID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmailID)
                .ForeignKey("dbo.Item", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ItemID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        ItemType = c.String(),
                        ItemDesc = c.String(),
                    })
                .PrimaryKey(t => t.ItemID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Email", "UserID", "dbo.User");
            DropForeignKey("dbo.Email", "ItemID", "dbo.Item");
            DropIndex("dbo.Email", new[] { "UserID" });
            DropIndex("dbo.Email", new[] { "ItemID" });
            DropTable("dbo.User");
            DropTable("dbo.Item");
            DropTable("dbo.Email");
        }
    }
}
