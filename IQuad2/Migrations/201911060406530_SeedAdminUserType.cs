namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminUserType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserTypes (Name, Description) VALUES('Admin', 'This particular user has administrative access to the application and can perform managerial and above tasks')");
        }
        
        public override void Down()
        {
        }
    }
}
