namespace Project_FTF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ftf : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Items_ID", "dbo.Item");
            DropForeignKey("dbo.Item", "AspNetUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Item", new[] { "AspNetUserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Items_ID" });
            DropColumn("dbo.Item", "AspNetUserId");
            DropColumn("dbo.AspNetUsers", "Items_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Items_ID", c => c.Int());
            AddColumn("dbo.Item", "AspNetUserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "Items_ID");
            CreateIndex("dbo.Item", "AspNetUserId");
            AddForeignKey("dbo.Item", "AspNetUserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUsers", "Items_ID", "dbo.Item", "ID");
        }
    }
}
