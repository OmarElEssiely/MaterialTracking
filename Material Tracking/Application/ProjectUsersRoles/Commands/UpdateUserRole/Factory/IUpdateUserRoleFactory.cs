using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MT.Application.ProjectUsersRoles.Commands.UpdateUserRole.Factory
{
    public interface IUpdateUserRoleFactory
    {
        UserProjectRole Create(UpdateUserRoleModel userRoleModel);
    }
}
