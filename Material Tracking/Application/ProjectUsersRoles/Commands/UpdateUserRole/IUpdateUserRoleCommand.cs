using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectUsersRoles.Commands.UpdateUserRole
{
    public interface IUpdateUserRoleCommand
    {

        void Execute(UpdateUserRoleModel userRoleModel);
    }
}
