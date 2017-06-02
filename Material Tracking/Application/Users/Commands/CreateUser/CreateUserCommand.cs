using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Users.Commands.Factory;

namespace Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUserFactory _factory;
        public CreateUserCommand(IDatabaseService database, IUserFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(CreateUserModel model)
        {
            var user = _factory.Create(
                model.Name,
                model.Email,
                model.Password,
                model.UserName
            );
            var role = _database.Roles.FirstOrDefault(r => r.RoleId == model.RoleId);
            if (role != null)
                user.Role = role;
            _database.Users.Add(user);
            _database.Save();
        }
    }
}
