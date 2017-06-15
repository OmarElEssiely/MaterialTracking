using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;


namespace MT.Application.ProjectUsersRoles.Commands.DeleteUserRole
{
    public class DeleteUserRoleCommand:IDeleteUserRoleCommand
    {
        private readonly IDatabaseService _database;
        public DeleteUserRoleCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(DeleteUserRoleModel userRoleModel)
        {
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == userRoleModel.ProjectId);
            if (project != null)
            {
                var projectuserrole =
                    project.UserProjectRoles.FirstOrDefault(x => x.UserProjectRoleId == userRoleModel.UserRoleId);
                project.UserProjectRoles.Remove(projectuserrole);
                _database.Save();
            }
        }
    }
}
