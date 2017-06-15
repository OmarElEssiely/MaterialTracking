using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.Admins.Queries.GetAdminByPassword
{
    public class GetAdminByPasswordQuery:IGetAdminByPasswordQuery
    {
        private readonly IDatabaseService _database;

        public GetAdminByPasswordQuery(IDatabaseService database)
        {
            _database = database;
        }
        public AdminModel Execute(string password)
        {
            var admin = _database.Admins.Where(a=>a.Password==password)
                           .Select(p => new AdminModel()
                           {
                               AdminId = p.AdminId,
                               Name = p.Name,
                               Email = p.Email,
                               Password = p.Password
                           }).FirstOrDefault();
            return admin;
        }
    }
}
