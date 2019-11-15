namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRegisterEntity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Id");
            DropColumn("dbo.Users", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserID", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "Id");
            AddPrimaryKey("dbo.Users", "UserID");
        }
    }
}
