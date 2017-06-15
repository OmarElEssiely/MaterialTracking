namespace Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "ClosedDate", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Projects", "Budget", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Budget");
            DropColumn("dbo.Projects", "ClosedDate");
        }
    }
}
