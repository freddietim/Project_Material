namespace Project_FTF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedapplicationDbContexttoLFContexteverywhere : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Items", newName: "Item");
            RenameTable(name: "dbo.Users", newName: "User");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.Item", newName: "Items");
        }
    }
}
