using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;
using MT.Domain;
using MT.Persistance;

namespace Persistance
{
    public class DatabaseService:DbContext,IDatabaseService
    {
        public IDbSet<Admin> Admins { get; set; }
        public IDbSet<Project> Projects { get; set; }
        public IDbSet<ProjectFile> ProjectFiles { get; set; }
        public IDbSet<ProjectFolder> ProjectFolders { get; set; }
        public IDbSet<ProjectSubFolder> ProjectSubFolders { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserProjectRole> UserProjectRoles { get; set; }
        public IDbSet<ProjectRfq> ProjectRfqs { get; set; }
        public IDbSet<RfqItem> RfqItems { get; set; }
        public IDbSet<RfqOffer> RfqOffers { get; set; }
        public IDbSet<ProjectIpr> ProjectIprs { get; set; }
        public IDbSet<ProjectIprPo> ProjectIprPos { get; set; }

        public DatabaseService() : base("MaterialTrackingDB")
        {

        }
        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new ProjectFolderConfiguration());
            modelBuilder.Configurations.Add(new ProjectSubFolderConfiguration());
            modelBuilder.Configurations.Add(new ProjectFilesConfiguration());
            modelBuilder.Configurations.Add(new AdminConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserProjectRoleConfiguration());
            modelBuilder.Configurations.Add(new InstallmentConfiguration());
            modelBuilder.Configurations.Add(new RFQConfiguration());
            modelBuilder.Configurations.Add(new RFQItemConfiguration());
            modelBuilder.Configurations.Add(new RFQOfferConfiguration());
            modelBuilder.Configurations.Add(new IPRConfiguration());
            modelBuilder.Configurations.Add(new IPRPoConfiguration());

        }
    }
}
