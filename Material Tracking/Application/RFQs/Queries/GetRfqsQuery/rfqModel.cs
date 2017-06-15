using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQs.Queries.GetRfqsQuery
{
    public class RfqModel
    {
        public int RfqId { get; set; }
        public string ProjectName { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
