namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataIntoUserType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into UserTypes (Name, Description) Values('Doctor', 'This user is a certified medical doctor')");
            Sql("Insert into UserTypes (Name, Description) Values('Secretary', 'This user is a employee that has been cleared to carry out various operations with patients')");
            Sql("Insert into UserTypes (Name, Description) Values('Patient', 'This user sets appointments and comes into office for medical checks')");
            Sql("INSERT INTO UserTypes (Name, Description) VALUES('Admin', 'This particular user has administrative access to the application and can perform managerial and above tasks')");
        }
        
        public override void Down()
        {
        }
    }
}
