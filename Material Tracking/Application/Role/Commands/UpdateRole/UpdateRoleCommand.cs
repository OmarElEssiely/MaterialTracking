using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Role.Commands.UpdateRole
{
    public class UpdateRoleCommand:IUpdateRoleCommand
    {
        private readonly IDatabaseService _database;

        public UpdateRoleCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(UpdateRoleModel model)
        {
            var role = _database.Roles.FirstOrDefault(r => r.RoleId == model.RoleId);
            if (role != null)
            {
                role.Name = model.Name;
                _database.Save();
            }
        }
    }
}
