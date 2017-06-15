using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectUsersRoles.Commands.AddUserRole
{
    public class AddUserRoleModel
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

    }
}
