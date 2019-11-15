namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredAttributeAddedToFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "PatientId", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "StartTime", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "EndTime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "EndTime", c => c.String());
            AlterColumn("dbo.Appointments", "StartTime", c => c.String());
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String());
            AlterColumn("dbo.Appointments", "PatientId", c => c.String());
        }
    }
}
