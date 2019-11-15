namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String(nullable: false));
        }
    }
}
