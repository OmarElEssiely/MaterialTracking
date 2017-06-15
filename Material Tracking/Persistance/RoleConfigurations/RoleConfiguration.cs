using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
    public class RoleConfiguration
        :EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            HasKey(p => p.RoleId);

            Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
