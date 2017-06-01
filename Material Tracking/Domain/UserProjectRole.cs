using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UserProjectRole
    {

        public int UserProjectRoleId { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
        public Role Role { get; set; }
    }
}
