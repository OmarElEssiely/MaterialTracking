using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Projects.Commands.CreateProject
{
    public class CreateProjectModel
    {
        public int ProjectId { get; set; }
        public string CustomerName { get; set; }
        public string ProjectSapNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime ClosedDate { get; set; }
        public decimal Budget { get; set; }
    }
}
