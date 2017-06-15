using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectUsersRoles.Commands.AddUserRole
{
    public interface IAddUserRoleCommand
    {
        void Execute(AddUserRoleModel userRoleModel);
    }
}
