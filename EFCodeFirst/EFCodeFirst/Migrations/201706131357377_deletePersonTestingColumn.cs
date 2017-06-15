namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletePersonTestingColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "TestingColumn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "TestingColumn", c => c.String());
        }
    }
}
