using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Admins.Commands.Factory;
using Application.Interfaces;

namespace Application.Admins.Commands.CreateAdmin
{
    public class CreateAdminCommand:ICreateAdminCommand
    {
        private readonly IDatabaseService _database;
        private readonly IAdminFactory _factory;

        public CreateAdminCommand(IDatabaseService database, IAdminFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(CreateAdminModel model)
        {
            var admin = _factory.Create(
                model.Name,
                model.Password,
                model.Email);
            _database.Admins.Add(admin);
            _database.Save();
        }
    }
}
