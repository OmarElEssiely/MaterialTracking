using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectUsersRoles.Commands.DeleteUserRole
{
    public class DeleteUserRoleModel
    {
        public int UserRoleId { get; set; }
        public int ProjectId { get; set; }
    }
}
