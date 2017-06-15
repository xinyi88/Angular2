namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigrationPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        UnitOrApartmentNumber = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Password = c.String(),
                        Slat = c.String(),
                        IsLocked = c.Boolean(),
                        LastLockedDateTime = c.DateTime(),
                        FailedAttemps = c.Int(),
                        SSN = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.Int(),
                        PeopleId = c.Int(),
                        HireDate = c.DateTime(),
                        Salary = c.Double(),
                        PeopleId1 = c.Int(),
                        EnrollmentDate = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
