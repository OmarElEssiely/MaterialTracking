using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Persistance
{
    public class RFQItemConfiguration
                : EntityTypeConfiguration<RfqItem>
    {
        public RFQItemConfiguration()
        {
            HasKey(a => a.RfqItemId);

            Property(a => a.PartNumber)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.DelivaryDate)
                .HasColumnType("date");
        }
    }
}
