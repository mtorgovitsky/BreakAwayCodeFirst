namespace BreakAwayCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Title = c.String(),
                        AddDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ContactID = c.Int(nullable: false),
                        CustomerTypeID = c.Int(nullable: false),
                        InitialDate = c.DateTime(),
                        PrimaryDesintation = c.Int(),
                        SecondaryDestination = c.Int(),
                        PrimaryActivity = c.Int(),
                        SecondaryActivity = c.Int(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ContactID)
                .ForeignKey("dbo.Contacts", t => t.ContactID)
                .Index(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "ContactID", "dbo.Contacts");
            DropIndex("dbo.Customers", new[] { "ContactID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Contacts");
        }
    }
}
