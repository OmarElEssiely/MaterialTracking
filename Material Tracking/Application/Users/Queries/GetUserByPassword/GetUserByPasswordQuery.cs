using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.Users.Queries.GetUserByPassword
{
    public class GetUserByPasswordQuery:IGetUserByPasswordQuery
    {
        private readonly IDatabaseService _database;

        public GetUserByPasswordQuery(IDatabaseService database)
        {
            _database = database;
        }
        public UserModel Execute(string password)
        {
            var user = _database.Users.Where(a=>a.Password == password).Select(p => new UserModel()
            {
                Email = p.Email,
                Password = p.Password,
                Name = p.Name,
                RoleId = p.Role.RoleId,
                UserName = p.UserName
            }).FirstOrDefault();
            return user;
        }
    }
}
