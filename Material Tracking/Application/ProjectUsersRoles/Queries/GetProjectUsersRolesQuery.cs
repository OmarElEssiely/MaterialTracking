using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.ProjectUsersRoles.Queries
{
    class GetProjectUsersRolesQuery:IGetProjectUsersRolesQuery
    {
        private readonly IDatabaseService _database;

        public GetProjectUsersRolesQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<ProjectUserRoleModel> Execute(int projectId)
        {
            var projectUsersList = new List<ProjectUserRoleModel>();
            var usersroles = _database.Projects.Where(p => p.ProjectId == projectId)
                .Select(p => p.UserProjectRoles).ToList();
            foreach (var userRole in usersroles)
            {
                var userrole = (from user in userRole
                              select user).FirstOrDefault();

                if (userrole != null)
                    projectUsersList.Add(new ProjectUserRoleModel()
                    {
                        ProjectId = userrole.Project.ProjectId,
                        RoleName = userrole.Role.Name,
                        UserName = userrole.User.UserName,
                        UserRoleId = userrole.UserProjectRoleId
                    });
            }
            return projectUsersList;
        }
    }
}
