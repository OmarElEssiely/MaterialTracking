using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Admins.Commands.DeleteAdmin
{
    public class DeleteAdminCommand:IDeleteAdminCommand
    {
        private readonly IDatabaseService _database;

        public DeleteAdminCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int adminId)
        {
          var admin=  _database.Admins.FirstOrDefault(a => a.AdminId == adminId);
            if (admin != null)
            {
                _database.Admins.Remove(admin);
                _database.Save();
            }
        }
    }
}
