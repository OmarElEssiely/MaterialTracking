using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Role.Queries.GetRoleList
{
    public class GetRoleListQuery:IGetRoleListQuery
    {
        private readonly IDatabaseService _database;

        public GetRoleListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<RoleModel> Execute()
        {
            var roles = _database.Roles.Select(p => new RoleModel()
            {
                RoleId = p.RoleId,
                Name = p.Name
            });
            return roles.ToList();
        }
    }
}
