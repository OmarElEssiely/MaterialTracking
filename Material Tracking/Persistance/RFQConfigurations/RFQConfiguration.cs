using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MT.Domain;

namespace MT.Persistance
{
    public class RFQConfiguration
        :EntityTypeConfiguration<ProjectRfq>
    {
        public RFQConfiguration()
        {
            HasKey(a => a.RfqId);

            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(a => a.Status)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.PublishDate)
                .HasColumnType("date");

        }
    }
}
