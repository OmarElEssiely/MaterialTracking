using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.Role.Queries.GetRoleById
{
    public class GetRoleByIdQuery:IGetRoleByIdQuery
    {
        private readonly IDatabaseService _database;

        public GetRoleByIdQuery(IDatabaseService database)
        {
            _database = database;
        }

        public RoleModel Execute(int roleId)
        {
            var role = _database.Roles.Where(r=>r.RoleId == roleId).Select(p => new RoleModel()
            {
                RoleId = p.RoleId,
                Name = p.Name
            }).FirstOrDefault();
            return role;
        }
    }
}
