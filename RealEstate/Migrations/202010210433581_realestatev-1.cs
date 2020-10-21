namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class realestatev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch_tbl",
                c => new
                    {
                        branchNo = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        city = c.String(),
                        postcode = c.String(),
                    })
                .PrimaryKey(t => t.branchNo);
            
            CreateTable(
                "dbo.Owner_tbl",
                c => new
                    {
                        ownerNo = c.String(nullable: false, maxLength: 128),
                        fName = c.String(),
                        lName = c.String(),
                        address = c.String(),
                        telNo = c.String(),
                    })
                .PrimaryKey(t => t.ownerNo);
            
            CreateTable(
                "dbo.Rent_tbl",
                c => new
                    {
                        propertyNo = c.String(nullable: false, maxLength: 128),
                        street = c.String(),
                        city = c.String(),
                        ptype = c.String(),
                        rooms = c.Int(nullable: false),
                        ownerNoref = c.String(maxLength: 128),
                        staffNoref = c.String(maxLength: 128),
                        branchNoRef = c.String(maxLength: 128),
                        rent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.propertyNo)
                .ForeignKey("dbo.Branch_tbl", t => t.branchNoRef)
                .ForeignKey("dbo.Owner_tbl", t => t.ownerNoref)
                .ForeignKey("dbo.Staff_tbl", t => t.staffNoref)
                .Index(t => t.ownerNoref)
                .Index(t => t.staffNoref)
                .Index(t => t.branchNoRef);
            
            CreateTable(
                "dbo.Staff_tbl",
                c => new
                    {
                        staffNo = c.String(nullable: false, maxLength: 128),
                        fName = c.String(),
                        lName = c.String(),
                        position = c.String(),
                        dateOfBirth = c.DateTime(nullable: false),
                        salary = c.Int(nullable: false),
                        branchNoRef = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.staffNo)
                .ForeignKey("dbo.Branch_tbl", t => t.branchNoRef)
                .Index(t => t.branchNoRef);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rent_tbl", "staffNoref", "dbo.Staff_tbl");
            DropForeignKey("dbo.Staff_tbl", "branchNoRef", "dbo.Branch_tbl");
            DropForeignKey("dbo.Rent_tbl", "ownerNoref", "dbo.Owner_tbl");
            DropForeignKey("dbo.Rent_tbl", "branchNoRef", "dbo.Branch_tbl");
            DropIndex("dbo.Staff_tbl", new[] { "branchNoRef" });
            DropIndex("dbo.Rent_tbl", new[] { "branchNoRef" });
            DropIndex("dbo.Rent_tbl", new[] { "staffNoref" });
            DropIndex("dbo.Rent_tbl", new[] { "ownerNoref" });
            DropTable("dbo.Staff_tbl");
            DropTable("dbo.Rent_tbl");
            DropTable("dbo.Owner_tbl");
            DropTable("dbo.Branch_tbl");
        }
    }
}
