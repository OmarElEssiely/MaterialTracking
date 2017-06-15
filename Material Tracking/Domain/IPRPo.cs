using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Domain
{
    public class ProjectIprPo
    {
        public int ProjectIprPoId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Path { get; set; }
        public ProjectIpr ProjectIpr { get; set; }
    }
}
