namespace Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstIteration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.ProjectFiles",
                c => new
                    {
                        ProjectFileId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Path = c.String(nullable: false, maxLength: 200),
                        Project_ProjectId = c.Int(nullable: false),
                        ProjectSubFolder_ProjectSubFolderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectFileId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .ForeignKey("dbo.ProjectSubFolders", t => t.ProjectSubFolder_ProjectSubFolderId)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.ProjectSubFolder_ProjectSubFolderId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 150),
                        ProjectSapNumber = c.String(nullable: false, maxLength: 150),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                        CreationDate = c.DateTime(nullable: false, storeType: "date"),
                        Description = c.String(nullable: false),
                        Status = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.UserProjectRoles",
                c => new
                    {
                        UserProjectRoleId = c.Int(nullable: false, identity: true),
                        Project_ProjectId = c.Int(nullable: false),
                        Role_RoleId = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserProjectRoleId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .ForeignKey("dbo.Roles", t => t.Role_RoleId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.Role_RoleId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 200),
                        UserName = c.String(nullable: false, maxLength: 200),
                        Role_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.Role_RoleId)
                .Index(t => t.Role_RoleId);
            
            CreateTable(
                "dbo.ProjectSubFolders",
                c => new
                    {
                        ProjectSubFolderId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        ProjectFolder_ProjectFolderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectSubFolderId)
                .ForeignKey("dbo.ProjectFolders", t => t.ProjectFolder_ProjectFolderId)
                .Index(t => t.ProjectFolder_ProjectFolderId);
            
            CreateTable(
                "dbo.ProjectFolders",
                c => new
                    {
                        ProjectFolderId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ProjectFolderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectFiles", "ProjectSubFolder_ProjectSubFolderId", "dbo.ProjectSubFolders");
            DropForeignKey("dbo.ProjectSubFolders", "ProjectFolder_ProjectFolderId", "dbo.ProjectFolders");
            DropForeignKey("dbo.ProjectFiles", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.UserProjectRoles", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserProjectRoles", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserProjectRoles", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.ProjectSubFolders", new[] { "ProjectFolder_ProjectFolderId" });
            DropIndex("dbo.Users", new[] { "Role_RoleId" });
            DropIndex("dbo.UserProjectRoles", new[] { "User_UserId" });
            DropIndex("dbo.UserProjectRoles", new[] { "Role_RoleId" });
            DropIndex("dbo.UserProjectRoles", new[] { "Project_ProjectId" });
            DropIndex("dbo.ProjectFiles", new[] { "ProjectSubFolder_ProjectSubFolderId" });
            DropIndex("dbo.ProjectFiles", new[] { "Project_ProjectId" });
            DropTable("dbo.ProjectFolders");
            DropTable("dbo.ProjectSubFolders");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.UserProjectRoles");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectFiles");
            DropTable("dbo.Admins");
        }
    }
}
