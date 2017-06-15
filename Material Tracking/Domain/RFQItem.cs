using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Domain
{
    public class RfqItem
    {
        public int RfqItemId { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime DelivaryDate { get; set; }
        public ProjectRfq ProjectRfq { get; set; }
    }
}
