namespace Demo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteCourses : DbMigration
    {
        public override void Up()
        {
            Sql("DROP TABLE Courses");
        }
        
        public override void Down()
        {
        }
    }
}
