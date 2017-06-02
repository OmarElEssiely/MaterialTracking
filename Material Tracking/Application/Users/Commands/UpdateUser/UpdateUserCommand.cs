using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand:IUpdateUserCommand
    {
        private readonly IDatabaseService _database;

        public UpdateUserCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(UpdateUserModel model)
        {
            var role = _database.Roles.FirstOrDefault(r => r.RoleId == model.RoleId);
            var user = _database.Users.FirstOrDefault(u => u.UserId == model.UserId);
            if (user!=null)
            {
                if (role != null)
                    user.Role = role;
                user.Email = model.Email;
                user.Name = model.Name;
                user.UserName = model.UserName;
                user.Password = model.Password;
                _database.Save();
            }
        }
    }
}
