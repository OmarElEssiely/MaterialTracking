using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistance
{
    public class UserProjectRoleConfiguration
        :EntityTypeConfiguration<UserProjectRole>
    {
        public UserProjectRoleConfiguration()
        {
            HasKey(p => p.UserProjectRoleId);

            HasRequired(p => p.Role);

            HasRequired(p => p.User);

            HasRequired(p => p.Project);

        }
    }
}
