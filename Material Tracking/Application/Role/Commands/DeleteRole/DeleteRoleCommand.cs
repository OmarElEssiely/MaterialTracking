using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Role.Commands.DeleteRole
{
    public class DeleteRoleCommand:IDeleteRoleCommand
    {
        private readonly IDatabaseService _database;

        public DeleteRoleCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int roleId)
        {
            var role = _database.Roles.FirstOrDefault(a => a.RoleId == roleId);
            if (role != null)
            {
                _database.Roles.Remove(role);
                _database.Save();
            }
        }
    }
}
