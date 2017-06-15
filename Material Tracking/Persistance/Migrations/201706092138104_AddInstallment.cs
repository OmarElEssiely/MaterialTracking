namespace Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstallment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Installments",
                c => new
                    {
                        InstallmentId = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDate = c.DateTime(nullable: false),
                        Comments = c.String(),
                        Project_ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.InstallmentId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .Index(t => t.Project_ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Installments", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.Installments", new[] { "Project_ProjectId" });
            DropTable("dbo.Installments");
        }
    }
}
