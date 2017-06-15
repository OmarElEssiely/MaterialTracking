using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;

namespace MT.Application.ProjectUsersRoles.Commands.AddUserRole.Factory
{
    public class UserRoleFactory:IUserRoleFactory
    {
        private readonly IDatabaseService _database;
        public UserRoleFactory(IDatabaseService database)
        {
            _database = database;
        }
        public UserProjectRole Create(AddUserRoleModel userRoleModel)
        {
            var userProject = new UserProjectRole
            {
                Project = _database.Projects.FirstOrDefault(p => p.ProjectId == userRoleModel.ProjectId),
                Role = _database.Roles.FirstOrDefault(r => r.RoleId == userRoleModel.RoleId),
                User = _database.Users.FirstOrDefault(u => u.UserId == userRoleModel.UserId)
            };
            return userProject;
        }
    }
}
