using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
    public class ProjectFilesConfiguration
        :EntityTypeConfiguration<ProjectFile>
    {
        public ProjectFilesConfiguration()
        {
            HasKey(p => p.ProjectFileId);

            Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Path)
                .HasMaxLength(200)
                .IsRequired();

            HasRequired(p => p.Project);

            HasRequired(p => p.ProjectSubFolder);
        }
    }
}
