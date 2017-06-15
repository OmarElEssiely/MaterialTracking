using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MT.Domain
{
    public class ProjectIpr
    {
        public int ProjectIprId { get; set; }
        public Project Project { get; set; }
        public ProjectRfq ProjectRfq { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public ICollection<ProjectIprPo> ProjectIprPos { get; set; }

    }
}
