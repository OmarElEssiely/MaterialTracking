namespace Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RFQandIPR : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectSubFolders", "Path", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectSubFolders", "Path");
        }
    }
}
