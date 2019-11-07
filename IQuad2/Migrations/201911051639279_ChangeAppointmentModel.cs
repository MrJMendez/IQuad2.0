namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAppointmentModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "PatientId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Appointments", new[] { "PatientId", "DoctorId", "Date" });
            DropColumn("dbo.Appointments", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String());
            AlterColumn("dbo.Appointments", "PatientId", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Appointments", "Id");
        }
    }
}
