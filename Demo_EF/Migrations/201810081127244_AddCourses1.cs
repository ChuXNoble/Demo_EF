namespace Demo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourses1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Course_Name,Semester) VALUES ('ADSE',4)");
            Sql("INSERT INTO Courses (Course_Name,Semester) VALUES ('ACNS',4)");
            Sql("INSERT INTO Courses (Course_Name,Semester) VALUES ('CPISM',1)");
            Sql("INSERT INTO Courses (Course_Name,Semester) VALUES ('DISM',2)");
            Sql("INSERT INTO Courses (Course_Name,Semester) VALUES ('IT',1)");
        }
        
        public override void Down()
        {
        }
    }
}
