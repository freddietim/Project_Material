namespace Project_FTF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Item", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Item", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Item", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Item", "ItemType", c => c.String(nullable: false));
            AlterColumn("dbo.Item", "ItemDesc", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Item", "ItemDesc", c => c.String());
            AlterColumn("dbo.Item", "ItemType", c => c.String());
            AlterColumn("dbo.Item", "EmailAddress", c => c.String());
            AlterColumn("dbo.Item", "FirstName", c => c.String());
            AlterColumn("dbo.Item", "Status", c => c.String());
        }
    }
}
