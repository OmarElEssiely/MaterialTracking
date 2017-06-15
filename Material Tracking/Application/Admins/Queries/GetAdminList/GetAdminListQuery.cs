using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Application.Interfaces;

namespace Application.Admins.Queries.GetAdminList
{
    public class GetAdminListQuery :IGetAdminListQuery
    {
        private readonly IDatabaseService _database;

        public GetAdminListQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<AdminModel> Execute()
        {
            var admins = _database.Admins
                .Select(p => new AdminModel()
                {
                    AdminId = p.AdminId,
                    Name = p.Name,
                    Email = p.Email,
                    Password = p.Password
                });
            return admins.ToList();
        }
    }
}
