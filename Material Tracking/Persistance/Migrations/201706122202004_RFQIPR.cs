namespace Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RFQIPR : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectIprs",
                c => new
                    {
                        ProjectIprId = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 200),
                        Status = c.String(nullable: false, maxLength: 50),
                        Comment = c.String(),
                        Project_ProjectId = c.Int(),
                        ProjectRfq_RfqId = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectIprId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .ForeignKey("dbo.ProjectRfqs", t => t.ProjectRfq_RfqId)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.ProjectRfq_RfqId);
            
            CreateTable(
                "dbo.ProjectIprPoes",
                c => new
                    {
                        ProjectIprPoId = c.Int(nullable: false, identity: true),
                        PublishDate = c.DateTime(nullable: false, storeType: "date"),
                        Path = c.String(nullable: false, maxLength: 200),
                        ProjectIpr_ProjectIprId = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectIprPoId)
                .ForeignKey("dbo.ProjectIprs", t => t.ProjectIpr_ProjectIprId)
                .Index(t => t.ProjectIpr_ProjectIprId);
            
            CreateTable(
                "dbo.ProjectRfqs",
                c => new
                    {
                        RfqId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        PublishDate = c.DateTime(nullable: false, storeType: "date"),
                        Status = c.String(nullable: false, maxLength: 200),
                        Comment = c.String(),
                        Project_ProjectId = c.Int(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.RfqId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.RfqItems",
                c => new
                    {
                        RfqItemId = c.Int(nullable: false, identity: true),
                        PartNumber = c.String(nullable: false, maxLength: 200),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(),
                        DelivaryDate = c.DateTime(nullable: false, storeType: "date"),
                        ProjectRfq_RfqId = c.Int(),
                    })
                .PrimaryKey(t => t.RfqItemId)
                .ForeignKey("dbo.ProjectRfqs", t => t.ProjectRfq_RfqId)
                .Index(t => t.ProjectRfq_RfqId);
            
            CreateTable(
                "dbo.RfqOffers",
                c => new
                    {
                        RfqOfferId = c.Int(nullable: false, identity: true),
                        PublishDate = c.DateTime(nullable: false, storeType: "date"),
                        Path = c.String(nullable: false, maxLength: 200),
                        Status = c.String(nullable: false, maxLength: 50),
                        ProjectRfq_RfqId = c.Int(),
                    })
                .PrimaryKey(t => t.RfqOfferId)
                .ForeignKey("dbo.ProjectRfqs", t => t.ProjectRfq_RfqId)
                .Index(t => t.ProjectRfq_RfqId);
            
            AlterColumn("dbo.Installments", "DueDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectRfqs", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.RfqOffers", "ProjectRfq_RfqId", "dbo.ProjectRfqs");
            DropForeignKey("dbo.RfqItems", "ProjectRfq_RfqId", "dbo.ProjectRfqs");
            DropForeignKey("dbo.ProjectIprs", "ProjectRfq_RfqId", "dbo.ProjectRfqs");
            DropForeignKey("dbo.ProjectRfqs", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ProjectIprPoes", "ProjectIpr_ProjectIprId", "dbo.ProjectIprs");
            DropForeignKey("dbo.ProjectIprs", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.RfqOffers", new[] { "ProjectRfq_RfqId" });
            DropIndex("dbo.RfqItems", new[] { "ProjectRfq_RfqId" });
            DropIndex("dbo.ProjectRfqs", new[] { "User_UserId" });
            DropIndex("dbo.ProjectRfqs", new[] { "Project_ProjectId" });
            DropIndex("dbo.ProjectIprPoes", new[] { "ProjectIpr_ProjectIprId" });
            DropIndex("dbo.ProjectIprs", new[] { "ProjectRfq_RfqId" });
            DropIndex("dbo.ProjectIprs", new[] { "Project_ProjectId" });
            AlterColumn("dbo.Installments", "DueDate", c => c.DateTime(nullable: false));
            DropTable("dbo.RfqOffers");
            DropTable("dbo.RfqItems");
            DropTable("dbo.ProjectRfqs");
            DropTable("dbo.ProjectIprPoes");
            DropTable("dbo.ProjectIprs");
        }
    }
}
