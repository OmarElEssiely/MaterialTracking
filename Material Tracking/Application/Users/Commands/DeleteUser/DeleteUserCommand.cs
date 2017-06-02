using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommand:IDeleteUserCommand
    {
        private readonly IDatabaseService _database;

        public DeleteUserCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int userId)
        {
            var user = _database.Users.FirstOrDefault(a => a.UserId == userId);
            if (user != null)
            {
                _database.Users.Remove(user);
                _database.Save();
            }
        }
    }
}
