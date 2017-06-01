using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
    public class ProjectSubFolderConfiguration
        :EntityTypeConfiguration<ProjectSubFolder>
    {
        public ProjectSubFolderConfiguration()
        {
            HasKey(p => p.ProjectSubFolderId);

            Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired();

            HasRequired(p => p.ProjectFolder);
        }
    }
}
