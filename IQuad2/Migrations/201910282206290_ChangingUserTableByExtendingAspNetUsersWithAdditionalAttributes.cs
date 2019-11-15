namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingUserTableByExtendingAspNetUsersWithAdditionalAttributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Initial", c => c.String());
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Street", c => c.String());
            AddColumn("dbo.AspNetUsers", "District", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Parish", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "UserTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserTypeId");
            DropColumn("dbo.AspNetUsers", "Parish");
            DropColumn("dbo.AspNetUsers", "District");
            DropColumn("dbo.AspNetUsers", "Street");
            DropColumn("dbo.AspNetUsers", "Age");
            DropColumn("dbo.AspNetUsers", "Initial");
        }
    }
}
