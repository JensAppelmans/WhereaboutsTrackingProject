namespace Whereabouts.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        AdressId = c.Int(nullable: false, identity: true),
                        Country = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        Street = c.String(nullable: false, maxLength: 50),
                        Zipcode = c.String(nullable: false, maxLength: 10),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdressId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phonenumber = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Company = c.String(maxLength: 50),
                        Btw = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.TrackedItems",
                c => new
                    {
                        TrackedItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        LicensePlate = c.String(maxLength: 50),
                        Brand = c.String(maxLength: 50),
                        ChassisNumber = c.String(nullable: false, maxLength: 50),
                        VehicleId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrackedItemId)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.VehicleId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Trackers",
                c => new
                    {
                        TrackerId = c.Int(nullable: false, identity: true),
                        IMEI = c.String(nullable: false, maxLength: 50),
                        ModelId = c.Int(nullable: false),
                        TrackedItem_TrackedItemId = c.Int(),
                    })
                .PrimaryKey(t => t.TrackerId)
                .ForeignKey("dbo.TrackerTypes", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.TrackedItems", t => t.TrackedItem_TrackedItemId)
                .Index(t => t.ModelId)
                .Index(t => t.TrackedItem_TrackedItemId);
            
            CreateTable(
                "dbo.TrackerTypes",
                c => new
                    {
                        TrackerTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TrackerTypeId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        picturePath = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrackedItems", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.TrackedItems", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Trackers", "TrackedItem_TrackedItemId", "dbo.TrackedItems");
            DropForeignKey("dbo.Trackers", "ModelId", "dbo.TrackerTypes");
            DropForeignKey("dbo.Adresses", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Trackers", new[] { "TrackedItem_TrackedItemId" });
            DropIndex("dbo.Trackers", new[] { "ModelId" });
            DropIndex("dbo.TrackedItems", new[] { "Customer_CustomerId" });
            DropIndex("dbo.TrackedItems", new[] { "VehicleId" });
            DropIndex("dbo.Adresses", new[] { "Customer_CustomerId" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.TrackerTypes");
            DropTable("dbo.Trackers");
            DropTable("dbo.TrackedItems");
            DropTable("dbo.Customers");
            DropTable("dbo.Adresses");
        }
    }
}
