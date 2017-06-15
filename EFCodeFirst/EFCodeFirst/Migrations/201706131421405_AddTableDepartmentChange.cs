namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableDepartmentChange : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "InstructorName");
            DropColumn("dbo.Departments", "InstructorId");
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "InstructorId", c => c.Int());
            AddColumn("dbo.Departments", "InstructorName", c => c.String());
        }
    }
}
