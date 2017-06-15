using System;
using System.Collections.Generic;
using MT.Domain;

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
        public DateTime ClosedDate { get; set; }
        public decimal Budget { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public ICollection<UserProjectRole> UserProjectRoles { get; set; }
        public ICollection<Installment> Installments { get; set; }
        public ICollection<ProjectRfq> ProjectRfqs { get; set; }
        public ICollection<ProjectIpr> ProjectIprs { get; set; }


    }
}
