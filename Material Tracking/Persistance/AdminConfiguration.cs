using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
    public class AdminConfiguration:EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
        {
            HasKey(a => a.AdminId);

            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Email)
              .IsRequired()
              .HasMaxLength(50);

            Property(a => a.Password)
              .IsRequired()
              .HasMaxLength(50);
        }
    }
}
