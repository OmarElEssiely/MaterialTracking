using System;
using System.Collections.Generic;

namespace Domain
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string CustomerName { get; set; }
        public string ProjectSapNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public ICollection<UserProjectRole> UserProjectRoles { get; set; }
    }
}
