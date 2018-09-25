namespace RadioCabs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Designation = c.String(),
                        Address = c.String(),
                        MobileNo = c.String(),
                        TelephoneNo = c.String(),
                        FaxNo = c.String(),
                        EmailAddress = c.String(),
                        Description = c.String(),
                        PaymentType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DriverName = c.String(),
                        Password = c.String(),
                        ContactPerson = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        MobileNo = c.String(),
                        TelephoneNo = c.String(),
                        EmailAddress = c.String(),
                        Experience = c.String(),
                        Description = c.String(),
                        PaymentType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MobileNo = c.String(),
                        EmailAddress = c.String(),
                        City = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Listings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Password = c.String(),
                        ContactPerson = c.String(),
                        Designation = c.String(),
                        Address = c.String(),
                        MobileNo = c.String(),
                        TelephoneNo = c.String(),
                        FaxNo = c.String(),
                        EmailAddress = c.String(),
                        MembershipType = c.String(),
                        PaymentType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Listings");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Drivers");
            DropTable("dbo.Advertisements");
        }
    }
}
