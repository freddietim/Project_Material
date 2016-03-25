namespace Project_FTF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dummy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Item", "ItemDesc", c => c.String(nullable: false, maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Item", "ItemDesc", c => c.String(nullable: false));
        }
    }
}
