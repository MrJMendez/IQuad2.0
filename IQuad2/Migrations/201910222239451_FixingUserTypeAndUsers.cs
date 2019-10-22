namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingUserTypeAndUsers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.Users", new[] { "UserTypeId" });
            DropPrimaryKey("dbo.UserTypes");
            AddColumn("dbo.UserTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Users", "UserTypeId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.UserTypes", "Id");
            CreateIndex("dbo.Users", "UserTypeId");
            AddForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.UserTypes", "UserTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserTypes", "UserTypeId", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.Users", new[] { "UserTypeId" });
            DropPrimaryKey("dbo.UserTypes");
            AlterColumn("dbo.Users", "UserTypeId", c => c.String(maxLength: 128));
            DropColumn("dbo.UserTypes", "Id");
            AddPrimaryKey("dbo.UserTypes", "UserTypeId");
            CreateIndex("dbo.Users", "UserTypeId");
            AddForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes", "UserTypeId");
        }
    }
}
