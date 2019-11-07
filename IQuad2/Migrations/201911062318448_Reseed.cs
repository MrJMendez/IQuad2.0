namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reseed : DbMigration
    {
        public override void Up()
        {
            Sql("dbcc checkident(UserTypes, 'RESEED', 0)");
        }
        
        public override void Down()
        {
        }
    }
}
