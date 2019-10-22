namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValuesIntoUserType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserTypes (UserTypeId, Name, Description) VALUES(1, 'Doctor', 'This particular user has been certified as a medical practitioner')");
            Sql("INSERT INTO UserTypes (UserTypeId, Name, Description) VALUES(2, 'Receptionist', 'This particular user is an employee at the organization that has been cleared to carry out various operations with patients')");
            Sql("INSERT INTO UserTypes (UserTypeId, Name, Description) VALUES(3, 'Patient', 'This particular user is a customer of the organization')");
        }
        
        public override void Down()
        {
        }
    }
}
