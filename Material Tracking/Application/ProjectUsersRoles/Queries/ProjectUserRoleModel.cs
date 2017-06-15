using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectUsersRoles.Queries
{
    public class ProjectUserRoleModel
    {
        public int  UserRoleId { get; set; }
        public int ProjectId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}
