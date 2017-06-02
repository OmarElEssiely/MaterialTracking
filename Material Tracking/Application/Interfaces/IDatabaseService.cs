using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<Admin> Admins { get; set; }
        IDbSet<Project> Projects { get; set; }
        IDbSet<ProjectFile> ProjectFiles { get; set; }
        IDbSet<ProjectFolder> ProjectFolders { get; set; }
        IDbSet<ProjectSubFolder> ProjectSubFolders { get; set; }
        IDbSet<Domain.Role> Roles { get; set; }
        IDbSet<User> Users { get; set; }
        IDbSet<UserProjectRole> UserProjectRoles { get; set; }
        void Save();
    }
}
