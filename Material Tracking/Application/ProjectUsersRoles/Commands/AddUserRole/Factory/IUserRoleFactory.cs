using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MT.Application.ProjectUsersRoles.Commands.AddUserRole.Factory
{
    public interface IUserRoleFactory
    {
        UserProjectRole Create(AddUserRoleModel userRoleModel);
    }
}
