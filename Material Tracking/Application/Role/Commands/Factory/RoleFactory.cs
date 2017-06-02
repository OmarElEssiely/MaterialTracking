using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Role.Commands.Factory
{
    public class RoleFactory:IRoleFactory
    {
        public Domain.Role Create(string name)
        {
            Domain.Role role = new Domain.Role();
            role.Name = name;
            return role;
        }
    }
}
