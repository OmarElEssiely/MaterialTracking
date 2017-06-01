using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Admins.Commands.Factory;
using Application.Interfaces;

namespace Application.Admins.Commands.UpdateAdmin
{
    public class UpdateAdminCommand:IUpdateAdminCommand
    {
        private readonly IDatabaseService _database;

        public UpdateAdminCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(UpdateAdminModel model)
        {
            var admin = _database.Admins.FirstOrDefault(a => a.AdminId == model.AdminId);
            if (admin != null)
            {
                admin.Email = model.Email;
                admin.Name = model.Name;
                admin.Password = model.Password;
                _database.Save();
            }
        }
    }
}
