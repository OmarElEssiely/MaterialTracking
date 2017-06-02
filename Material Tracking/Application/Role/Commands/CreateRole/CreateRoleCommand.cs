using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Role.Commands.Factory;

namespace Application.Role.Commands.CreateRole
{
    public class CreateRoleCommand:ICreateRoleCommand
    {
        private readonly IDatabaseService _database;
        private readonly IRoleFactory _factory;
        public CreateRoleCommand(IDatabaseService database, IRoleFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(CreateRoleModel model)
        {
            var role = _factory.Create(model.Name);
            _database.Roles.Add(role);
            _database.Save();
        }
    }
}
