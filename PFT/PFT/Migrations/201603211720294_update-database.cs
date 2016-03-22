namespace PFT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Email", "ItemID", "dbo.Item");
            DropPrimaryKey("dbo.Item");
            AddColumn("dbo.Item", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Item", "ItemID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Item", "ItemID");
            CreateIndex("dbo.Item", "UserId");
            AddForeignKey("dbo.Item", "UserId", "dbo.User", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Email", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Email", "ItemID", "dbo.Item");
            DropForeignKey("dbo.Item", "UserId", "dbo.User");
            DropIndex("dbo.Item", new[] { "UserId" });
            DropPrimaryKey("dbo.Item");
            AlterColumn("dbo.Item", "ItemID", c => c.Int(nullable: false));
            DropColumn("dbo.Item", "UserId");
            AddPrimaryKey("dbo.Item", "ItemID");
            AddForeignKey("dbo.Email", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
        }
    }
}
