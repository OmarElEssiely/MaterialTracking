using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.Role.Queries.GetRoleById
{
    public interface IGetRoleByIdQuery
    {
        RoleModel Execute(int roleId);
    }
}
