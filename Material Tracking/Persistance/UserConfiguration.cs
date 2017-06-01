using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
   public class UserConfiguration
        :EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(a => a.UserId);
          
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(a => a.Email)
              .IsRequired()
              .HasMaxLength(200);

            Property(a => a.Password)
              .IsRequired()
              .HasMaxLength(200);

            Property(a => a.UserName)
             .IsRequired()
             .HasMaxLength(200);
        }
    }
}
