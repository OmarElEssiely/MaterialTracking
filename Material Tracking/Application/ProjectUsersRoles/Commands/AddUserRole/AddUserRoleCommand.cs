using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.ProjectUsersRoles.Commands.AddUserRole.Factory;

namespace MT.Application.ProjectUsersRoles.Commands.AddUserRole
{
    public class AddUserRoleCommand:IAddUserRoleCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUserRoleFactory _factory;
        public AddUserRoleCommand(IDatabaseService database, IUserRoleFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(AddUserRoleModel userRoleModel)
        {
            var userRole = _factory.Create(userRoleModel);
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == userRoleModel.ProjectId);
            project?.UserProjectRoles.Add(userRole);
            _database.Save();
        }
    }
}
