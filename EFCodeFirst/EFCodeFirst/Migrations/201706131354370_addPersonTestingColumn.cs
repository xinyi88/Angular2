namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPersonTestingColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "TestingColumn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "TestingColumn");
        }
    }
}
