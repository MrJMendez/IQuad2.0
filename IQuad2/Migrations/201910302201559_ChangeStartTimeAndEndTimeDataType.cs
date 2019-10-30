namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStartTimeAndEndTimeDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "StartTime", c => c.String());
            AlterColumn("dbo.Appointments", "EndTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "EndTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Appointments", "StartTime", c => c.Time(nullable: false, precision: 7));
        }
    }
}
