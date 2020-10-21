namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class realestate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staff_tbl", "dateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staff_tbl", "dateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
