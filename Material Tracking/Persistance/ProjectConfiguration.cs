using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
    public class ProjectConfiguration
        :EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
            HasKey(p => p.ProjectId);

            Property(p => p.CustomerName)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Description)
                .IsRequired();

            Property(p => p.ProjectSapNumber)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Status)
                .HasMaxLength(250);

            Property(p => p.CreationDate)
                .HasColumnType("date");

            Property(p => p.StartDate)
                .HasColumnType("date");

            Property(p => p.EndDate)
                .HasColumnType("date");
        }
    }
}
