using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Persistance
{
    public class IPRPoConfiguration
                : EntityTypeConfiguration<ProjectIprPo>
    {
        public IPRPoConfiguration()
        {
            HasKey(a => a.ProjectIprPoId);

            Property(a => a.Path)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.PublishDate)
                .HasColumnType("date");
        }
    }
}
