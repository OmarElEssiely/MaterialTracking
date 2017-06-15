using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
    public class ProjectFolderConfiguration
        :EntityTypeConfiguration<ProjectFolder>
    {
        public ProjectFolderConfiguration()
        {
            HasKey(p => p.ProjectFolderId);

            Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
