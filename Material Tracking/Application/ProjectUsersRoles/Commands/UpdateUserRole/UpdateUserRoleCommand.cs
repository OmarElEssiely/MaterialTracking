using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.ProjectUsersRoles.Commands.UpdateUserRole.Factory;

namespace MT.Application.ProjectUsersRoles.Commands.UpdateUserRole
{
    public class UpdateUserRoleCommand:IUpdateUserRoleCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUpdateUserRoleFactory _factory;
        public UpdateUserRoleCommand(IDatabaseService database, IUpdateUserRoleFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(UpdateUserRoleModel userRoleModel)
        {
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == userRoleModel.ProjectId);
            if (project != null)
            {
                var userrole =project.UserProjectRoles.FirstOrDefault(x => x.UserProjectRoleId == userRoleModel.UserRoleId);
                var updateduserrole = _factory.Create(userRoleModel);
                if (userrole != null)
                {
                    userrole.Role = updateduserrole.Role;
                    userrole.Project = updateduserrole.Project;
                    userrole.User = updateduserrole.User;
                    _database.Save();
                }
            }
        }
    }
}
