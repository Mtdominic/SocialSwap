namespace git_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Things", "UserId", c => c.String());
            DropColumn("dbo.Things", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Things", "Username", c => c.String());
            DropColumn("dbo.Things", "UserId");
        }
    }
}
