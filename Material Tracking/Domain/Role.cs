using System.Collections.Generic;

namespace Domain
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public ICollection<UserProjectRole> UserProjectRoles { get; set; }
    }
}