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
        }
        
        public override void Down()
        {
        }
    }
}
