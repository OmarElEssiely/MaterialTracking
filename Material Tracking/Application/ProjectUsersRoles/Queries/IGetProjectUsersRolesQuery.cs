using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectUsersRoles.Queries
{
    public interface IGetProjectUsersRolesQuery
    {
        List<ProjectUserRoleModel> Execute(int projectId);
    }
}
