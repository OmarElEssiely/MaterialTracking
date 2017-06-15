using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRs.Queries.GetProjectIPRs
{
    public class GetProjectIprModel
    {
        public int ProjectIprId { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string RfqName { get; set; }

    }
}
