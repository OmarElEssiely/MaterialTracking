using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRs.Queries.GetIPRs
{
    public class GetRfqIprModel
    {
        public int ProjectIprId { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
