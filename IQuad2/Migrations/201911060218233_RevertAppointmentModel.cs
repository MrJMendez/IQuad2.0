namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevertAppointmentModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Appointments");
            AddColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Appointments", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Appointments", "PatientId", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String());
            AddPrimaryKey("dbo.Appointments", "Id");
            CreateIndex("dbo.Appointments", "User_Id");
            AddForeignKey("dbo.Appointments", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Appointments", new[] { "User_Id" });
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "DoctorId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Appointments", "PatientId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Appointments", "User_Id");
            DropColumn("dbo.Appointments", "Id");
            AddPrimaryKey("dbo.Appointments", new[] { "PatientId", "DoctorId", "Date" });
        }
    }
}
