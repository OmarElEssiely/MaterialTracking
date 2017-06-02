using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Users.Queries.GetUserList
{
    public class GetUserListQuery:IGetUserListQuery
    {
        private readonly IDatabaseService _database;

        public GetUserListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<UserModel> Execute()
        {
            var users = _database.Users.Select(p => new UserModel()
            {
                Email = p.Email,
                Password = p.Password,
                Name = p.Name,
                RoleId = p.Role.RoleId,
                UserName = p.UserName
            });
            return users.ToList();
        }
    }
}
