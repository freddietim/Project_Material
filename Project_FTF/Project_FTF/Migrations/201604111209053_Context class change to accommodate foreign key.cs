namespace Project_FTF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contextclasschangetoaccommodateforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "AspNetUserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Items_ID", c => c.Int());
            CreateIndex("dbo.Item", "AspNetUserId");
            CreateIndex("dbo.AspNetUsers", "Items_ID");
            AddForeignKey("dbo.AspNetUsers", "Items_ID", "dbo.Item", "ID");
            AddForeignKey("dbo.Item", "AspNetUserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "AspNetUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Items_ID", "dbo.Item");
            DropIndex("dbo.AspNetUsers", new[] { "Items_ID" });
            DropIndex("dbo.Item", new[] { "AspNetUserId" });
            DropColumn("dbo.AspNetUsers", "Items_ID");
            DropColumn("dbo.Item", "AspNetUserId");
        }
    }
}
