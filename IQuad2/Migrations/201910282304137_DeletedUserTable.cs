namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedUserTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.Users", new[] { "UserTypeId" });
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(nullable: false, maxLength: 255),
                        Lname = c.String(nullable: false, maxLength: 255),
                        Initial = c.String(),
                        Age = c.Byte(nullable: false),
                        PhoneNumber = c.String(),
                        District = c.String(),
                        Parish = c.String(),
                        Street = c.String(),
                        UserTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Users", "UserTypeId");
            AddForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes", "Id", cascadeDelete: true);
        }
    }
}
