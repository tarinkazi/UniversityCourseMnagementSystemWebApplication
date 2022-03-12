namespace UniversityCourseMnagementSystemWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Semester_Created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Semesters");
        }
    }
}
